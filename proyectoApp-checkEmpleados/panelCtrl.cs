using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace proyectoApp_checkEmpleados
{
    public partial class panelCtrl : Form
    {
        public string puerto;
        public bool auto = true;
        string codigo = "";
        bool to_start = false;

        public panelCtrl()
        {
            InitializeComponent();

            this.Opacity = 0;
        }

        private void panelCtrl_Load(object sender, EventArgs e)
        {
            if (!auto)
            {
                try
                {
                    timerReloj_Tick(null, null);
                    timerOpacityIn.Start();

                    serialPort1.PortName = puerto;
                    serialPort1.Open();
                }
                catch (Exception exc)
                {
                    msgOk ok = new msgOk();
                    Persistent p = new Persistent();
                    splash s = new splash();

                    ok.lblMsg.Text = ("Se produjo un error en conectar al puerto " + puerto + ": \n" +
                        exc.ToString() + " \nSeleccione un nuevo puerto valido.");
                    ok.ShowDialog();

                    p.deleter();

                    this.Hide();
                    s.Show();
                    this.Close();
                    this.Dispose();
                }

                panelReloj.Visible = true;
                panelInfo.Visible = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            timerPuerto.Stop();
            timerPuerto.Dispose();
            timerReloj.Stop();
            timerReloj.Dispose();

            timerOpacityOut.Start();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            msgSiNo siNo = new msgSiNo();

            siNo.lblMsg.Text = "¿Quieres regresar al menú de inicio?";
            result = siNo.ShowDialog();

            if (result == DialogResult.Yes)
            {
                Persistent persistent = new Persistent();
                serialPort1.Close();

                try
                {
                    persistent.deleter();

                    to_start = true;
                    timerOpacityOut.Start();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Se produjo un error \n': " + exc.ToString());
                }
            }
            else
            {
                siNo.Close();
                siNo.Dispose();
            }
        }

        double o = 0;
        private void timerOpacityIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < .6)
                o = 0.05;
            else if (this.Opacity > .6 && this.Opacity < .9)
                o = 0.03;
            else if (this.Opacity > .9 && this.Opacity < .97)
                o = 0.02;
            else if (this.Opacity >= .97)
            {
                o = 0;
                this.Opacity = 1;

                timerReloj.Start();
                timerPuerto.Start();

                timerOpacityIn.Stop();
                timerOpacityIn.Dispose();
                return;
            }

            this.Opacity += o;
        }

        private void timerOpacityOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0 && this.Opacity < .30)
                o = 0.08;
            else if (this.Opacity > .30 && this.Opacity < .50)
                o = 0.13;
            else if (this.Opacity > .50)
                o = 0.20;
            else
            {
                o = 0;
                this.Opacity = 0;

                timerOpacityOut.Stop();
                timerOpacityOut.Dispose();

                if (to_start)
                {
                    splash s = new splash();

                    this.Hide();
                    s.Show();
                    this.Close();
                }
                else
                {
                    Application.Exit();
                }
                
                return;
            }

            this.Opacity -= o;
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            if(lblHora.Text != DateTime.Now.ToString("HH:mm") || lblFecha.Text != DateTime.Now.ToLongDateString())
            {
                if(int.Parse(DateTime.Now.ToString("HH")) < 19 && int.Parse(DateTime.Now.ToString("HH")) > 12)
                {
                    lblSaludoIni.Text = "¡BUENAS TARDES! BIENVENIDO";
                }
                else if (int.Parse(DateTime.Now.ToString("HH")) > 19 || int.Parse(DateTime.Now.ToString("HH")) < 08)
                {
                    lblSaludoIni.Text = "¡BUENAS NOCHES! BIENVENIDO";
                }
                else if (int.Parse(DateTime.Now.ToString("HH")) > 8 && int.Parse(DateTime.Now.ToString("HH")) < 12)
                {
                    lblSaludoIni.Text = "¡BUENOS DÍAS! BIENVENIDO";
                }

                lblHora.Text = DateTime.Now.ToString("HH:mm");
                lblFecha.Text = DateTime.Now.ToLongDateString();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            codigo = serialPort1.ReadLine().Trim();
        }

        private void timerPuerto_Tick(object sender, EventArgs e)
        {
            if (codigo != lblCodigo.Text)
            {
                lblCodigo.Text = codigo;

                cProgressOut.Value = 20;

                try
                {
                    Conexion.Ejecutar(
                        string.Format("exec pInOut '{0}', 0, ''", codigo)
                    );
                    Conexion.Consulta(
                        string.Format("exec pInfo '{0}'", codigo)
                    );

                    string premios = "";

                    while (Conexion.result.Read()) //Llena txt's con datos
                    {
                        lblNombre.Text = Conexion.result["nombre"].ToString() + "!";
                        lblArea.Text = Conexion.result["area"].ToString();
                        lblHoraE.Text = DateTime.Now.ToString("HH:mm");
                        lblFaltas.Text = Conexion.result["faltas"].ToString();
                        lblRetardos.Text = Conexion.result["retardos"].ToString();

                        if (Conexion.result["empleado_del_mes"].ToString().Equals("v"))
                            premios += "> Empleado del mes\n";
                        if (Conexion.result["estajo"].ToString().Equals("v"))
                            premios += "> Estajo\n";
                        if (Conexion.result["puntualidad"].ToString().Equals("v"))
                            premios += "> Puntualidad\n";
                        if (Conexion.result["staff"].ToString().Equals("v"))
                            premios += "> Staff\n";
                        if (premios.Equals(""))
                            premios = "> Sin premios";

                        lblPremios.Text = premios;

                        if (Conexion.result["in_out"].ToString().Equals("e"))
                            lblSaludo.Text = "¡Hola";
                        else
                            lblSaludo.Text = "¡Adios";
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Se produjo un error en 'Conexion': \n" + 
                        exc.ToString(), "\nError de consulta a base de datos.");

                    msgOk ok = new msgOk();

                    ok.ShowDialog();
                    ok.lblMsg.Text = "Error faltal. No se pudo ejecutar las consultas " +
                        "a la base de datos!";
                }

                panelReloj.Visible = false;
                panelInfo.Visible = true;
            }

            if (cProgressOut.Value > 0)
            {
                cProgressOut.Value -= 1;
            }
            else if (cProgressOut.Value == 0)
            {
                lblFaltas.Text = "";
                lblHoraE.Text = "";
                lblNombre.Text = "";
                lblRetardos.Text = "";
                panelReloj.Visible = true;
                panelInfo.Visible = false;

                codigo = "";
                lblCodigo.Text = "";
            }
        }
    }
}

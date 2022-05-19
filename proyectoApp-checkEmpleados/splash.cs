using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using System.IO.Ports;

namespace proyectoApp_checkEmpleados
{
    public partial class splash : Form
    {
        int time = 0;
        string puerto;
        bool auto = false;

        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;

            drpPuertos_Items();

            timerOpacity.Start();
        }

        int tic = 0;
        int dir = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (circleLoad.Value == 75)
            {
                dir = -1;  // reduce
                circleLoad.animationIterval = 5;
            }
            else if (circleLoad.Value == 15)
            {
                dir = +1; //expand
                circleLoad.animationIterval = 3;
            }

            circleLoad.Value += dir;
        }

        private void timerOut_Tick(object sender, EventArgs e)
        {
            tic++;
            if (tic == time)
            {
                panelCtrl ctrl = new panelCtrl();

                ctrl.auto = false;
                ctrl.puerto = puerto;
                timer.Stop();
                timer.Dispose();
                timerOut.Stop();
                timerOut.Dispose();
                timerOpacity.Stop();
                timerOpacity.Dispose();

                this.Hide();
                //ctrl.ShowDialog();
                ctrl.Show();
                this.Close();
            }
        }

        double o = 0;
        private void timerOpacity_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < .50)
            {
                o = 0.05;
            }
            else if (this.Opacity > .50 && this.Opacity < .80)
            {
                o = 0.03;
            }
            else if (this.Opacity > .80 && this.Opacity < .97)
            {
                o = 0.02;
            }
            else if (this.Opacity >= .97)
            {
                o = 0;
                this.Opacity = 1;

                timerOpacity.Stop();
                timerOpacity.Dispose();
                return;
            }

            this.Opacity += o;
        }

        private void drpPuertos_onItemSelected(object sender, EventArgs e)
        {
            if (drpPuertos.selectedIndex != 0)
            {
                btnSig.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                btnSig.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;

            cardPuertos.Visible = false;
            panelCarga.Visible = true;
            panelCarga.Enabled = true;
            bar.Visible = false;
            bar.Enabled = false;

            cardPuertos.color = Color.MediumSlateBlue;

            if (!auto)
                puerto = drpPuertos.selectedValue;

            circleLoad.animated = true;

            Random rnd = new Random();
            time = rnd.Next(3, 5 + 1);

            timer.Start();
            timerOut.Start();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persistent p = new Persistent();
            msgOk ok = new msgOk();

            p.setter(drpPuertos.selectedValue);
            if (p.getter().Equals(drpPuertos.selectedValue))
            {
                ok.lblMsg.Text = "Se ha guardado '" + drpPuertos.selectedValue + 
                    "' como puerto predeterminado.";
                ok.ShowDialog();
                btnGuardar.Enabled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            drpPuertos.Clear();
            drpPuertos_Items();
        }        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drpPuertos_Items()
        {
            Persistent p = new Persistent();

            string[] ports = SerialPort.GetPortNames();

            string port = p.traker();

            drpPuertos.AddItem("Puetos");
            foreach (string portFound in ports) { drpPuertos.AddItem(portFound); }
            drpPuertos.selectedIndex = 0;

            for (int i = 0; ports.Length > i; i++)
            {
                if (ports[i].Equals(port))
                {
                    puerto = port;
                    auto = true;
                    btnSig_Click(null, null);
                }
            }
        }
    }
}

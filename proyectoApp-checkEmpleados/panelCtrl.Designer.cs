namespace proyectoApp_checkEmpleados
{
    partial class panelCtrl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelCtrl));
            this.bar = new System.Windows.Forms.Panel();
            this.btnAtras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.panelReloj = new System.Windows.Forms.Panel();
            this.lblSaludoIni = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPremios = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelArea = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.panelHoraE = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHoraE = new System.Windows.Forms.Label();
            this.panelFaltas = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.panelRetardo = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRetardos = new System.Windows.Forms.Label();
            this.panelMsg = new System.Windows.Forms.Panel();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cProgressOut = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.timerOpacityIn = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerPuerto = new System.Windows.Forms.Timer(this.components);
            this.timerOpacityOut = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelReloj.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelArea.SuspendLayout();
            this.panelHoraE.SuspendLayout();
            this.panelFaltas.SuspendLayout();
            this.panelRetardo.SuspendLayout();
            this.panelMsg.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bar.Controls.Add(this.btnAtras);
            this.bar.Controls.Add(this.panel1);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1203, 41);
            this.bar.TabIndex = 5;
            // 
            // btnAtras
            // 
            this.btnAtras.Activecolor = System.Drawing.Color.Transparent;
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.BorderRadius = 0;
            this.btnAtras.ButtonText = "";
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.DisabledColor = System.Drawing.Color.Gray;
            this.btnAtras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAtras.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.salir;
            this.btnAtras.Iconimage_right = null;
            this.btnAtras.Iconimage_right_Selected = null;
            this.btnAtras.Iconimage_Selected = null;
            this.btnAtras.IconMarginLeft = 0;
            this.btnAtras.IconMarginRight = 0;
            this.btnAtras.IconRightVisible = false;
            this.btnAtras.IconRightZoom = 0D;
            this.btnAtras.IconVisible = true;
            this.btnAtras.IconZoom = 55D;
            this.btnAtras.IsTab = false;
            this.btnAtras.Location = new System.Drawing.Point(1120, 1);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAtras.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(218)))), ((int)(((byte)(0)))));
            this.btnAtras.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtras.selected = false;
            this.btnAtras.Size = new System.Drawing.Size(40, 40);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtras.Textcolor = System.Drawing.Color.White;
            this.btnAtras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1163, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 41);
            this.panel1.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Activecolor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.BorderRadius = 0;
            this.btnCerrar.ButtonText = "";
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Iconimage")));
            this.btnCerrar.Iconimage_right = null;
            this.btnCerrar.Iconimage_right_Selected = null;
            this.btnCerrar.Iconimage_Selected = null;
            this.btnCerrar.IconMarginLeft = 0;
            this.btnCerrar.IconMarginRight = 0;
            this.btnCerrar.IconRightVisible = false;
            this.btnCerrar.IconRightZoom = 0D;
            this.btnCerrar.IconVisible = true;
            this.btnCerrar.IconZoom = 55D;
            this.btnCerrar.IsTab = false;
            this.btnCerrar.Location = new System.Drawing.Point(0, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCerrar.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrar.selected = false;
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Textcolor = System.Drawing.Color.White;
            this.btnCerrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // timerReloj
            // 
            this.timerReloj.Interval = 12000;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // panelReloj
            // 
            this.panelReloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelReloj.Controls.Add(this.bunifuCustomLabel1);
            this.panelReloj.Controls.Add(this.lblSaludoIni);
            this.panelReloj.Controls.Add(this.lblHora);
            this.panelReloj.Controls.Add(this.lblFecha);
            this.panelReloj.Location = new System.Drawing.Point(0, 57);
            this.panelReloj.Name = "panelReloj";
            this.panelReloj.Size = new System.Drawing.Size(1203, 578);
            this.panelReloj.TabIndex = 7;
            // 
            // lblSaludoIni
            // 
            this.lblSaludoIni.Font = new System.Drawing.Font("Leelawadee UI Semilight", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludoIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lblSaludoIni.Location = new System.Drawing.Point(3, 56);
            this.lblSaludoIni.Name = "lblSaludoIni";
            this.lblSaludoIni.Size = new System.Drawing.Size(1197, 54);
            this.lblSaludoIni.TabIndex = 10;
            this.lblSaludoIni.Text = "¡BUENOS DÍAS! BIENVENIDO";
            this.lblSaludoIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lblHora.Location = new System.Drawing.Point(3, 141);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(1197, 108);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "4:20";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.lblFecha.Location = new System.Drawing.Point(3, 260);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(1197, 40);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "una fecha bastante larga, ¿o no?";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelInfo.Controls.Add(this.panel7);
            this.panelInfo.Controls.Add(this.flowLayoutPanel1);
            this.panelInfo.Controls.Add(this.panel4);
            this.panelInfo.Controls.Add(this.lblNombre);
            this.panelInfo.Controls.Add(this.lblSaludo);
            this.panelInfo.Location = new System.Drawing.Point(11, 57);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1179, 567);
            this.panelInfo.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel7.Controls.Add(this.bunifuFlatButton6);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.lblPremios);
            this.panel7.Location = new System.Drawing.Point(879, 196);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(285, 206);
            this.panel7.TabIndex = 20;
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Enabled = false;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.estrella;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = false;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 100D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(0, 48);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(100, 100);
            this.bunifuFlatButton6.TabIndex = 20;
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(186)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(106, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Premios";
            // 
            // lblPremios
            // 
            this.lblPremios.BackColor = System.Drawing.Color.Transparent;
            this.lblPremios.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.lblPremios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(186)))), ((int)(((byte)(67)))));
            this.lblPremios.Location = new System.Drawing.Point(106, 43);
            this.lblPremios.Name = "lblPremios";
            this.lblPremios.Size = new System.Drawing.Size(168, 157);
            this.lblPremios.TabIndex = 19;
            this.lblPremios.Tag = "";
            this.lblPremios.Text = "<1\r\n>2\r\n<3\r\n>4\r\n<5\r\n>6\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panelArea);
            this.flowLayoutPanel1.Controls.Add(this.panelHoraE);
            this.flowLayoutPanel1.Controls.Add(this.panelFaltas);
            this.flowLayoutPanel1.Controls.Add(this.panelRetardo);
            this.flowLayoutPanel1.Controls.Add(this.panelMsg);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(289, 193);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 355);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // panelArea
            // 
            this.panelArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panelArea.Controls.Add(this.bunifuFlatButton1);
            this.panelArea.Controls.Add(this.label1);
            this.panelArea.Controls.Add(this.lblArea);
            this.panelArea.Location = new System.Drawing.Point(3, 3);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(285, 100);
            this.panelArea.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton1.Enabled = false;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.contacto;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 100D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(100, 100);
            this.bunifuFlatButton1.TabIndex = 16;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.label1.Location = new System.Drawing.Point(106, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Area";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArea
            // 
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.lblArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.lblArea.Location = new System.Drawing.Point(111, 38);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(164, 54);
            this.lblArea.TabIndex = 15;
            this.lblArea.Tag = "";
            this.lblArea.Text = "Area\r\n101\r\n\r\n";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHoraE
            // 
            this.panelHoraE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panelHoraE.Controls.Add(this.bunifuFlatButton2);
            this.panelHoraE.Controls.Add(this.label5);
            this.panelHoraE.Controls.Add(this.lblHoraE);
            this.panelHoraE.Location = new System.Drawing.Point(294, 3);
            this.panelHoraE.Name = "panelHoraE";
            this.panelHoraE.Size = new System.Drawing.Size(285, 100);
            this.panelHoraE.TabIndex = 17;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton2.Enabled = false;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.reloj;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 100D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(100, 100);
            this.bunifuFlatButton2.TabIndex = 20;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(106, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hora de check";
            // 
            // lblHoraE
            // 
            this.lblHoraE.AutoSize = true;
            this.lblHoraE.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraE.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.lblHoraE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(225)))), ((int)(((byte)(102)))));
            this.lblHoraE.Location = new System.Drawing.Point(122, 57);
            this.lblHoraE.Name = "lblHoraE";
            this.lblHoraE.Size = new System.Drawing.Size(60, 26);
            this.lblHoraE.TabIndex = 19;
            this.lblHoraE.Tag = "";
            this.lblHoraE.Text = "07:55";
            this.lblHoraE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFaltas
            // 
            this.panelFaltas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panelFaltas.Controls.Add(this.bunifuFlatButton3);
            this.panelFaltas.Controls.Add(this.label6);
            this.panelFaltas.Controls.Add(this.lblFaltas);
            this.panelFaltas.Location = new System.Drawing.Point(3, 109);
            this.panelFaltas.Name = "panelFaltas";
            this.panelFaltas.Size = new System.Drawing.Size(285, 100);
            this.panelFaltas.TabIndex = 17;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton3.Enabled = false;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.cancelar;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 100D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(100, 100);
            this.bunifuFlatButton3.TabIndex = 17;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(103)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(106, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Faltas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.BackColor = System.Drawing.Color.Transparent;
            this.lblFaltas.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.lblFaltas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(103)))), ((int)(((byte)(117)))));
            this.lblFaltas.Location = new System.Drawing.Point(122, 57);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(23, 26);
            this.lblFaltas.TabIndex = 15;
            this.lblFaltas.Tag = "";
            this.lblFaltas.Text = "0";
            this.lblFaltas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelRetardo
            // 
            this.panelRetardo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panelRetardo.Controls.Add(this.bunifuFlatButton4);
            this.panelRetardo.Controls.Add(this.label8);
            this.panelRetardo.Controls.Add(this.lblRetardos);
            this.panelRetardo.Location = new System.Drawing.Point(294, 109);
            this.panelRetardo.Name = "panelRetardo";
            this.panelRetardo.Size = new System.Drawing.Size(285, 100);
            this.panelRetardo.TabIndex = 21;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton4.Enabled = false;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.error;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 100D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(100, 100);
            this.bunifuFlatButton4.TabIndex = 20;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(106, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Retardos";
            // 
            // lblRetardos
            // 
            this.lblRetardos.AutoSize = true;
            this.lblRetardos.BackColor = System.Drawing.Color.Transparent;
            this.lblRetardos.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.lblRetardos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.lblRetardos.Location = new System.Drawing.Point(122, 57);
            this.lblRetardos.Name = "lblRetardos";
            this.lblRetardos.Size = new System.Drawing.Size(23, 26);
            this.lblRetardos.TabIndex = 19;
            this.lblRetardos.Tag = "";
            this.lblRetardos.Text = "0";
            this.lblRetardos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMsg
            // 
            this.panelMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panelMsg.Controls.Add(this.bunifuFlatButton5);
            this.panelMsg.Controls.Add(this.label11);
            this.panelMsg.Controls.Add(this.label10);
            this.panelMsg.Location = new System.Drawing.Point(3, 215);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.Size = new System.Drawing.Size(576, 128);
            this.panelMsg.TabIndex = 21;
            this.panelMsg.Visible = false;
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.info;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 100D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(100, 128);
            this.bunifuFlatButton5.TabIndex = 21;
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(122, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(451, 58);
            this.label11.TabIndex = 17;
            this.label11.Tag = "";
            this.label11.Text = "El mensaje\r\nxD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(106, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 26);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mensaje personalizado";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1179, 81);
            this.panel4.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.cProgressOut);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(1029, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 81);
            this.panel6.TabIndex = 1;
            // 
            // cProgressOut
            // 
            this.cProgressOut.animated = false;
            this.cProgressOut.animationIterval = 5;
            this.cProgressOut.animationSpeed = 300;
            this.cProgressOut.BackColor = System.Drawing.Color.Transparent;
            this.cProgressOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cProgressOut.BackgroundImage")));
            this.cProgressOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cProgressOut.ForeColor = System.Drawing.Color.Transparent;
            this.cProgressOut.LabelVisible = false;
            this.cProgressOut.LineProgressThickness = 4;
            this.cProgressOut.LineThickness = 2;
            this.cProgressOut.Location = new System.Drawing.Point(75, 7);
            this.cProgressOut.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cProgressOut.MaxValue = 40;
            this.cProgressOut.Name = "cProgressOut";
            this.cProgressOut.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.cProgressOut.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(192)))), ((int)(((byte)(28)))));
            this.cProgressOut.Size = new System.Drawing.Size(65, 65);
            this.cProgressOut.TabIndex = 12;
            this.cProgressOut.Value = 20;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.lblCodigo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(455, 81);
            this.panel5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(105, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(287, 39);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 53F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(285, 84);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(588, 106);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre!";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSaludo
            // 
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 33F);
            this.lblSaludo.ForeColor = System.Drawing.Color.White;
            this.lblSaludo.Location = new System.Drawing.Point(31, 118);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(260, 59);
            this.lblSaludo.TabIndex = 10;
            this.lblSaludo.Text = "!Bienvenido";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerOpacityIn
            // 
            this.timerOpacityIn.Interval = 10;
            this.timerOpacityIn.Tick += new System.EventHandler(this.timerOpacityIn_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(122)))), ((int)(((byte)(34)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1203, 11);
            this.panel3.TabIndex = 8;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timerPuerto
            // 
            this.timerPuerto.Interval = 1000;
            this.timerPuerto.Tick += new System.EventHandler(this.timerPuerto_Tick);
            // 
            // timerOpacityOut
            // 
            this.timerOpacityOut.Interval = 10;
            this.timerOpacityOut.Tick += new System.EventHandler(this.timerOpacityOut_Tick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 423);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(1197, 76);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Acerca tu tarjeta al modulo";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1203, 656);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.panelReloj);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panelCtrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "panelCtrl";
            this.Load += new System.EventHandler(this.panelCtrl_Load);
            this.bar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelReloj.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelArea.ResumeLayout(false);
            this.panelArea.PerformLayout();
            this.panelHoraE.ResumeLayout(false);
            this.panelHoraE.PerformLayout();
            this.panelFaltas.ResumeLayout(false);
            this.panelFaltas.PerformLayout();
            this.panelRetardo.ResumeLayout(false);
            this.panelRetardo.PerformLayout();
            this.panelMsg.ResumeLayout(false);
            this.panelMsg.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bar;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerReloj;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHora;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSaludoIni;
        private System.Windows.Forms.Timer timerOpacityIn;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblCodigo;
        private Bunifu.Framework.UI.BunifuCircleProgressbar cProgressOut;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelArea;
        private System.Windows.Forms.Panel panelHoraE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHoraE;
        private System.Windows.Forms.Panel panelFaltas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFaltas;
        private System.Windows.Forms.Panel panelRetardo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRetardos;
        private System.Windows.Forms.Panel panelMsg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPremios;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerPuerto;
        internal System.Windows.Forms.Panel panelReloj;
        internal System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtras;
        private System.Windows.Forms.Timer timerOpacityOut;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
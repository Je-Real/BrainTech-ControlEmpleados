namespace proyectoApp_checkEmpleados
{
    partial class splash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblIni = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelCarga = new System.Windows.Forms.Panel();
            this.circleLoad = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bar = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drpPuertos = new Bunifu.Framework.UI.BunifuDropdown();
            this.cardPuertos = new Bunifu.Framework.UI.BunifuCards();
            this.btnActualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSig = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timerOut = new System.Windows.Forms.Timer(this.components);
            this.timerOpacity = new System.Windows.Forms.Timer(this.components);
            this.panelCarga.SuspendLayout();
            this.bar.SuspendLayout();
            this.cardPuertos.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblIni
            // 
            this.lblIni.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIni.Location = new System.Drawing.Point(12, 11);
            this.lblIni.Name = "lblIni";
            this.lblIni.Size = new System.Drawing.Size(307, 39);
            this.lblIni.TabIndex = 1;
            this.lblIni.Text = "Iniciando";
            this.lblIni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCarga
            // 
            this.panelCarga.Controls.Add(this.lblIni);
            this.panelCarga.Controls.Add(this.circleLoad);
            this.panelCarga.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCarga.Location = new System.Drawing.Point(0, 339);
            this.panelCarga.Name = "panelCarga";
            this.panelCarga.Size = new System.Drawing.Size(331, 175);
            this.panelCarga.TabIndex = 2;
            this.panelCarga.Visible = false;
            // 
            // circleLoad
            // 
            this.circleLoad.animated = false;
            this.circleLoad.animationIterval = 2;
            this.circleLoad.animationSpeed = 1;
            this.circleLoad.BackColor = System.Drawing.Color.Transparent;
            this.circleLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleLoad.BackgroundImage")));
            this.circleLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleLoad.ForeColor = System.Drawing.Color.SeaGreen;
            this.circleLoad.LabelVisible = false;
            this.circleLoad.LineProgressThickness = 8;
            this.circleLoad.LineThickness = 5;
            this.circleLoad.Location = new System.Drawing.Point(119, 53);
            this.circleLoad.MaxValue = 100;
            this.circleLoad.Name = "circleLoad";
            this.circleLoad.ProgressBackColor = System.Drawing.Color.Transparent;
            this.circleLoad.ProgressColor = System.Drawing.Color.MediumTurquoise;
            this.circleLoad.Size = new System.Drawing.Size(92, 92);
            this.circleLoad.TabIndex = 0;
            this.circleLoad.Value = 5;
            // 
            // bar
            // 
            this.bar.Controls.Add(this.btnCerrar);
            this.bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(331, 41);
            this.bar.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Activecolor = System.Drawing.Color.Red;
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
            this.btnCerrar.Location = new System.Drawing.Point(293, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCerrar.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnCerrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrar.selected = false;
            this.btnCerrar.Size = new System.Drawing.Size(36, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Textcolor = System.Drawing.Color.White;
            this.btnCerrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 64);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(307, 39);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Escoge un puerto...";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drpPuertos
            // 
            this.drpPuertos.AutoSize = true;
            this.drpPuertos.BackColor = System.Drawing.Color.Transparent;
            this.drpPuertos.BorderRadius = 3;
            this.drpPuertos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drpPuertos.DisabledColor = System.Drawing.Color.White;
            this.drpPuertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpPuertos.ForeColor = System.Drawing.Color.White;
            this.drpPuertos.Items = new string[0];
            this.drpPuertos.Location = new System.Drawing.Point(57, 125);
            this.drpPuertos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drpPuertos.Name = "drpPuertos";
            this.drpPuertos.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(111)))), ((int)(((byte)(232)))));
            this.drpPuertos.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(86)))), ((int)(((byte)(232)))));
            this.drpPuertos.selectedIndex = -1;
            this.drpPuertos.Size = new System.Drawing.Size(217, 35);
            this.drpPuertos.TabIndex = 0;
            this.drpPuertos.onItemSelected += new System.EventHandler(this.drpPuertos_onItemSelected);
            // 
            // cardPuertos
            // 
            this.cardPuertos.BackColor = System.Drawing.Color.Transparent;
            this.cardPuertos.BorderRadius = 0;
            this.cardPuertos.BottomSahddow = false;
            this.cardPuertos.color = System.Drawing.Color.Tomato;
            this.cardPuertos.Controls.Add(this.btnActualizar);
            this.cardPuertos.Controls.Add(this.btnGuardar);
            this.cardPuertos.Controls.Add(this.btnSig);
            this.cardPuertos.Controls.Add(this.drpPuertos);
            this.cardPuertos.Controls.Add(this.bunifuCustomLabel1);
            this.cardPuertos.LeftSahddow = false;
            this.cardPuertos.Location = new System.Drawing.Point(0, 41);
            this.cardPuertos.Name = "cardPuertos";
            this.cardPuertos.RightSahddow = false;
            this.cardPuertos.ShadowDepth = 20;
            this.cardPuertos.Size = new System.Drawing.Size(331, 298);
            this.cardPuertos.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Activecolor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.BorderRadius = 0;
            this.btnActualizar.ButtonText = "";
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btnActualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnActualizar.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.actualizar;
            this.btnActualizar.Iconimage_right = null;
            this.btnActualizar.Iconimage_right_Selected = null;
            this.btnActualizar.Iconimage_Selected = null;
            this.btnActualizar.IconMarginLeft = 0;
            this.btnActualizar.IconMarginRight = 0;
            this.btnActualizar.IconRightVisible = true;
            this.btnActualizar.IconRightZoom = 0D;
            this.btnActualizar.IconVisible = true;
            this.btnActualizar.IconZoom = 90D;
            this.btnActualizar.IsTab = false;
            this.btnActualizar.Location = new System.Drawing.Point(140, 247);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnActualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(87)))), ((int)(((byte)(205)))));
            this.btnActualizar.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnActualizar.selected = false;
            this.btnActualizar.Size = new System.Drawing.Size(50, 48);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Textcolor = System.Drawing.Color.White;
            this.btnActualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(106)))), ((int)(((byte)(50)))));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "Puerto Default";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = global::proyectoApp_checkEmpleados.Properties.Resources.guardar;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = false;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 50D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(178, 198);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(141, 42);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Puerto Default";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Textcolor = System.Drawing.Color.White;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSig
            // 
            this.btnSig.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(106)))), ((int)(((byte)(50)))));
            this.btnSig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSig.BorderRadius = 0;
            this.btnSig.ButtonText = "Continuar";
            this.btnSig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSig.DisabledColor = System.Drawing.Color.Gray;
            this.btnSig.Enabled = false;
            this.btnSig.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSig.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSig.Iconimage")));
            this.btnSig.Iconimage_right = null;
            this.btnSig.Iconimage_right_Selected = null;
            this.btnSig.Iconimage_Selected = null;
            this.btnSig.IconMarginLeft = 0;
            this.btnSig.IconMarginRight = 0;
            this.btnSig.IconRightVisible = false;
            this.btnSig.IconRightZoom = 0D;
            this.btnSig.IconVisible = true;
            this.btnSig.IconZoom = 55D;
            this.btnSig.IsTab = false;
            this.btnSig.Location = new System.Drawing.Point(17, 198);
            this.btnSig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSig.Name = "btnSig";
            this.btnSig.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnSig.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSig.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSig.selected = false;
            this.btnSig.Size = new System.Drawing.Size(141, 42);
            this.btnSig.TabIndex = 3;
            this.btnSig.Text = "Continuar";
            this.btnSig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSig.Textcolor = System.Drawing.Color.White;
            this.btnSig.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // timerOut
            // 
            this.timerOut.Interval = 1000;
            this.timerOut.Tick += new System.EventHandler(this.timerOut_Tick);
            // 
            // timerOpacity
            // 
            this.timerOpacity.Interval = 10;
            this.timerOpacity.Tick += new System.EventHandler(this.timerOpacity_Tick);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(331, 514);
            this.Controls.Add(this.cardPuertos);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.panelCarga);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.splash_Load);
            this.panelCarga.ResumeLayout(false);
            this.bar.ResumeLayout(false);
            this.cardPuertos.ResumeLayout(false);
            this.cardPuertos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleLoad;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIni;
        private System.Windows.Forms.Panel panelCarga;
        private System.Windows.Forms.Panel bar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown drpPuertos;
        private Bunifu.Framework.UI.BunifuCards cardPuertos;
        private Bunifu.Framework.UI.BunifuFlatButton btnSig;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrar;
        private System.Windows.Forms.Timer timerOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.Timer timerOpacity;
        private Bunifu.Framework.UI.BunifuFlatButton btnActualizar;
    }
}


namespace InterfazAdministrador
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContenedor = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.gbLogoMenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRoles = new Guna.UI2.WinForms.Guna2Button();
            this.btnTurnos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmpleados = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAsistencia = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSalir = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfiguracion = new Guna.UI2.WinForms.Guna2Button();
            this.btnDatosBiometricos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEstadisticas = new Guna.UI2.WinForms.Guna2Button();
            this.btnHorasExtras = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbLogoMenu)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(185)))), ((int)(((byte)(148)))));
            this.guna2Panel1.BorderRadius = 40;
            this.guna2Panel1.Controls.Add(this.btnMinimizar);
            this.guna2Panel1.Controls.Add(this.pnlContenedor);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.btnCerrar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(952, 640);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.AutoRoundedCorners = true;
            this.btnMinimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(858, 14);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(36, 23);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.pnlContenedor.BorderRadius = 40;
            this.pnlContenedor.Controls.Add(this.lblBienvenida);
            this.pnlContenedor.Controls.Add(this.gbLogoMenu);
            this.pnlContenedor.Location = new System.Drawing.Point(230, 49);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(707, 575);
            this.pnlContenedor.TabIndex = 3;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Location = new System.Drawing.Point(216, 352);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(108, 19);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "lblBienvenida";
            // 
            // gbLogoMenu
            // 
            this.gbLogoMenu.Image = global::InterfazAdministrador.Properties.Resources.logoq;
            this.gbLogoMenu.ImageRotate = 0F;
            this.gbLogoMenu.Location = new System.Drawing.Point(124, 2);
            this.gbLogoMenu.Margin = new System.Windows.Forms.Padding(2);
            this.gbLogoMenu.Name = "gbLogoMenu";
            this.gbLogoMenu.Size = new System.Drawing.Size(466, 455);
            this.gbLogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gbLogoMenu.TabIndex = 1;
            this.gbLogoMenu.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.guna2Panel2.BorderRadius = 40;
            this.guna2Panel2.Controls.Add(this.btnRoles);
            this.guna2Panel2.Controls.Add(this.btnTurnos);
            this.guna2Panel2.Controls.Add(this.btnEmpleados);
            this.guna2Panel2.Controls.Add(this.BtnAsistencia);
            this.guna2Panel2.Controls.Add(this.BtnSalir);
            this.guna2Panel2.Controls.Add(this.btnConfiguracion);
            this.guna2Panel2.Controls.Add(this.btnDatosBiometricos);
            this.guna2Panel2.Controls.Add(this.btnEstadisticas);
            this.guna2Panel2.Controls.Add(this.btnHorasExtras);
            this.guna2Panel2.Controls.Add(this.btnModificar);
            this.guna2Panel2.Location = new System.Drawing.Point(19, 49);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(215, 575);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.Transparent;
            this.btnRoles.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.btnRoles.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnRoles.ForeColor = System.Drawing.Color.DimGray;
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoles.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRoles.Location = new System.Drawing.Point(2, 375);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(211, 37);
            this.btnRoles.TabIndex = 9;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.BackColor = System.Drawing.Color.Transparent;
            this.btnTurnos.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTurnos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTurnos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTurnos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTurnos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTurnos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.btnTurnos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnTurnos.ForeColor = System.Drawing.Color.DimGray;
            this.btnTurnos.Image = ((System.Drawing.Image)(resources.GetObject("btnTurnos.Image")));
            this.btnTurnos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTurnos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTurnos.Location = new System.Drawing.Point(2, 334);
            this.btnTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(211, 37);
            this.btnTurnos.TabIndex = 8;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmpleados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmpleados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.btnEmpleados.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.DimGray;
            this.btnEmpleados.Image = global::InterfazAdministrador.Properties.Resources.datos_personales1;
            this.btnEmpleados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmpleados.ImageSize = new System.Drawing.Size(38, 30);
            this.btnEmpleados.Location = new System.Drawing.Point(2, 182);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(211, 37);
            this.btnEmpleados.TabIndex = 4;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // BtnAsistencia
            // 
            this.BtnAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.BtnAsistencia.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAsistencia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAsistencia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAsistencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAsistencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAsistencia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.BtnAsistencia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsistencia.ForeColor = System.Drawing.Color.DimGray;
            this.BtnAsistencia.Image = global::InterfazAdministrador.Properties.Resources.asistencia1;
            this.BtnAsistencia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAsistencia.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnAsistencia.Location = new System.Drawing.Point(2, 31);
            this.BtnAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAsistencia.Name = "BtnAsistencia";
            this.BtnAsistencia.Size = new System.Drawing.Size(211, 49);
            this.BtnAsistencia.TabIndex = 0;
            this.BtnAsistencia.Text = "Asistencia";
            this.BtnAsistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnAsistencia.Click += new System.EventHandler(this.BtnAsistencia_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.BtnSalir.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.DimGray;
            this.BtnSalir.Image = global::InterfazAdministrador.Properties.Resources.salir;
            this.BtnSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSalir.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnSalir.Location = new System.Drawing.Point(24, 525);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(123, 37);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfiguracion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfiguracion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfiguracion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfiguracion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfiguracion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.btnConfiguracion.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfiguracion.Image = global::InterfazAdministrador.Properties.Resources.configuracion;
            this.btnConfiguracion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfiguracion.ImageSize = new System.Drawing.Size(30, 30);
            this.btnConfiguracion.Location = new System.Drawing.Point(23, 485);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(158, 37);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "Configuracion";
            this.btnConfiguracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnDatosBiometricos
            // 
            this.btnDatosBiometricos.BackColor = System.Drawing.Color.Transparent;
            this.btnDatosBiometricos.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatosBiometricos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDatosBiometricos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDatosBiometricos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDatosBiometricos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDatosBiometricos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.btnDatosBiometricos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDatosBiometricos.ForeColor = System.Drawing.Color.DimGray;
            this.btnDatosBiometricos.Image = global::InterfazAdministrador.Properties.Resources.datos_biometricos;
            this.btnDatosBiometricos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDatosBiometricos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDatosBiometricos.Location = new System.Drawing.Point(2, 264);
            this.btnDatosBiometricos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatosBiometricos.Name = "btnDatosBiometricos";
            this.btnDatosBiometricos.Size = new System.Drawing.Size(211, 37);
            this.btnDatosBiometricos.TabIndex = 5;
            this.btnDatosBiometricos.Text = "Datos Biometricos";
            this.btnDatosBiometricos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDatosBiometricos.Click += new System.EventHandler(this.btnDatosBiometricos_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadisticas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadisticas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEstadisticas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEstadisticas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEstadisticas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.btnEstadisticas.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEstadisticas.ForeColor = System.Drawing.Color.DimGray;
            this.btnEstadisticas.Image = global::InterfazAdministrador.Properties.Resources.empleado;
            this.btnEstadisticas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEstadisticas.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEstadisticas.Location = new System.Drawing.Point(2, 223);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(211, 37);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnHorasExtras
            // 
            this.btnHorasExtras.BackColor = System.Drawing.Color.Transparent;
            this.btnHorasExtras.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHorasExtras.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHorasExtras.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHorasExtras.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHorasExtras.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHorasExtras.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.btnHorasExtras.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorasExtras.ForeColor = System.Drawing.Color.DimGray;
            this.btnHorasExtras.Image = global::InterfazAdministrador.Properties.Resources.horasextras;
            this.btnHorasExtras.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHorasExtras.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHorasExtras.Location = new System.Drawing.Point(2, 121);
            this.btnHorasExtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnHorasExtras.Name = "btnHorasExtras";
            this.btnHorasExtras.Size = new System.Drawing.Size(211, 37);
            this.btnHorasExtras.TabIndex = 2;
            this.btnHorasExtras.Text = "Horas Extras";
            this.btnHorasExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHorasExtras.Click += new System.EventHandler(this.btnHorasExtras_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(185)))));
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.DimGray;
            this.btnModificar.Image = global::InterfazAdministrador.Properties.Resources.modificar1;
            this.btnModificar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModificar.ImageSize = new System.Drawing.Size(30, 30);
            this.btnModificar.Location = new System.Drawing.Point(2, 80);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(211, 37);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoRoundedCorners = true;
            this.btnCerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCerrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(900, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(36, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 640);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a";
            this.guna2Panel1.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbLogoMenu)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnMinimizar;
        private Guna.UI2.WinForms.Guna2Panel pnlContenedor;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button BtnAsistencia;
        private Guna.UI2.WinForms.Guna2Button BtnSalir;
        private Guna.UI2.WinForms.Guna2Button btnConfiguracion;
        private Guna.UI2.WinForms.Guna2Button btnDatosBiometricos;
        private Guna.UI2.WinForms.Guna2Button btnEmpleados;
        private Guna.UI2.WinForms.Guna2Button btnEstadisticas;
        private Guna.UI2.WinForms.Guna2Button btnHorasExtras;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
        private Guna.UI2.WinForms.Guna2PictureBox gbLogoMenu;
        private System.Windows.Forms.Label lblBienvenida;
        private Guna.UI2.WinForms.Guna2Button btnRoles;
        private Guna.UI2.WinForms.Guna2Button btnTurnos;
    }
}
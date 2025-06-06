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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDatosBiometricos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelAsistencia = new System.Windows.Forms.Panel();
            this.panelDatosBiometricos = new System.Windows.Forms.Panel();
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.lblCantidadCaras = new System.Windows.Forms.Label();
            this.lblMostrarIniciandoCamara = new System.Windows.Forms.Label();
            this.btnEliminarCara = new System.Windows.Forms.Button();
            this.btnAgregarCara = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.pbMostrarCaras = new System.Windows.Forms.PictureBox();
            this.btnFiltrarPanelCara = new System.Windows.Forms.Button();
            this.txtFiltrarPanelCara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEmpleadosCaras = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCaras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMostrarATF = new System.Windows.Forms.DataGridView();
            this.ColEmpleado2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTardanzas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFaltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportarMes = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.dgvMostrarReporteDia = new System.Windows.Forms.DataGridView();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAsistencia.SuspendLayout();
            this.panelDatosBiometricos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarCaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosCaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarATF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReporteDia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnDatosBiometricos);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 595);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 334);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Configuración";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnDatosBiometricos
            // 
            this.btnDatosBiometricos.Location = new System.Drawing.Point(63, 279);
            this.btnDatosBiometricos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatosBiometricos.Name = "btnDatosBiometricos";
            this.btnDatosBiometricos.Size = new System.Drawing.Size(126, 33);
            this.btnDatosBiometricos.TabIndex = 7;
            this.btnDatosBiometricos.Text = "Datos biométricos";
            this.btnDatosBiometricos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatosBiometricos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(50, 544);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 24);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(63, 231);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 33);
            this.button5.TabIndex = 5;
            this.button5.Text = "Datos personales";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 184);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Empleados";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(63, 134);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 33);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(30, 87);
            this.btnAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(112, 33);
            this.btnAsistencia.TabIndex = 2;
            this.btnAsistencia.Text = "Asistencia";
            this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(71, 39);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            // 
            // panelAsistencia
            // 
            this.panelAsistencia.Controls.Add(this.panelDatosBiometricos);
            this.panelAsistencia.Controls.Add(this.label1);
            this.panelAsistencia.Controls.Add(this.dgvMostrarATF);
            this.panelAsistencia.Controls.Add(this.btnExportarMes);
            this.panelAsistencia.Controls.Add(this.cmbMes);
            this.panelAsistencia.Controls.Add(this.cmbAno);
            this.panelAsistencia.Controls.Add(this.dgvMostrarReporteDia);
            this.panelAsistencia.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAsistencia.Location = new System.Drawing.Point(223, 0);
            this.panelAsistencia.Name = "panelAsistencia";
            this.panelAsistencia.Size = new System.Drawing.Size(710, 595);
            this.panelAsistencia.TabIndex = 3;
            // 
            // panelDatosBiometricos
            // 
            this.panelDatosBiometricos.Controls.Add(this.btnEliminarFiltro);
            this.panelDatosBiometricos.Controls.Add(this.lblCantidadCaras);
            this.panelDatosBiometricos.Controls.Add(this.lblMostrarIniciandoCamara);
            this.panelDatosBiometricos.Controls.Add(this.btnEliminarCara);
            this.panelDatosBiometricos.Controls.Add(this.btnAgregarCara);
            this.panelDatosBiometricos.Controls.Add(this.btnSiguiente);
            this.panelDatosBiometricos.Controls.Add(this.btnAnterior);
            this.panelDatosBiometricos.Controls.Add(this.pbMostrarCaras);
            this.panelDatosBiometricos.Controls.Add(this.btnFiltrarPanelCara);
            this.panelDatosBiometricos.Controls.Add(this.txtFiltrarPanelCara);
            this.panelDatosBiometricos.Controls.Add(this.label2);
            this.panelDatosBiometricos.Controls.Add(this.dgvEmpleadosCaras);
            this.panelDatosBiometricos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDatosBiometricos.Location = new System.Drawing.Point(700, 0);
            this.panelDatosBiometricos.Name = "panelDatosBiometricos";
            this.panelDatosBiometricos.Size = new System.Drawing.Size(10, 595);
            this.panelDatosBiometricos.TabIndex = 8;
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Location = new System.Drawing.Point(502, 30);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFiltro.TabIndex = 12;
            this.btnEliminarFiltro.Text = "EliminarFiltro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // lblCantidadCaras
            // 
            this.lblCantidadCaras.AutoSize = true;
            this.lblCantidadCaras.ForeColor = System.Drawing.Color.Blue;
            this.lblCantidadCaras.Location = new System.Drawing.Point(492, 372);
            this.lblCantidadCaras.Name = "lblCantidadCaras";
            this.lblCantidadCaras.Size = new System.Drawing.Size(35, 13);
            this.lblCantidadCaras.TabIndex = 11;
            this.lblCantidadCaras.Text = "label3";
            // 
            // lblMostrarIniciandoCamara
            // 
            this.lblMostrarIniciandoCamara.AutoSize = true;
            this.lblMostrarIniciandoCamara.ForeColor = System.Drawing.Color.Red;
            this.lblMostrarIniciandoCamara.Location = new System.Drawing.Point(348, 450);
            this.lblMostrarIniciandoCamara.Name = "lblMostrarIniciandoCamara";
            this.lblMostrarIniciandoCamara.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarIniciandoCamara.TabIndex = 10;
            this.lblMostrarIniciandoCamara.Text = "label3";
            // 
            // btnEliminarCara
            // 
            this.btnEliminarCara.Location = new System.Drawing.Point(520, 409);
            this.btnEliminarCara.Name = "btnEliminarCara";
            this.btnEliminarCara.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarCara.TabIndex = 9;
            this.btnEliminarCara.Text = "Eliminar Cara";
            this.btnEliminarCara.UseVisualStyleBackColor = true;
            this.btnEliminarCara.Click += new System.EventHandler(this.btnEliminarCara_Click);
            // 
            // btnAgregarCara
            // 
            this.btnAgregarCara.Location = new System.Drawing.Point(391, 409);
            this.btnAgregarCara.Name = "btnAgregarCara";
            this.btnAgregarCara.Size = new System.Drawing.Size(105, 23);
            this.btnAgregarCara.TabIndex = 8;
            this.btnAgregarCara.Text = "Agregar Cara";
            this.btnAgregarCara.UseVisualStyleBackColor = true;
            this.btnAgregarCara.Click += new System.EventHandler(this.btnAgregarCara_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(565, 367);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(378, 367);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // pbMostrarCaras
            // 
            this.pbMostrarCaras.Location = new System.Drawing.Point(351, 76);
            this.pbMostrarCaras.Name = "pbMostrarCaras";
            this.pbMostrarCaras.Size = new System.Drawing.Size(320, 274);
            this.pbMostrarCaras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarCaras.TabIndex = 5;
            this.pbMostrarCaras.TabStop = false;
            // 
            // btnFiltrarPanelCara
            // 
            this.btnFiltrarPanelCara.Location = new System.Drawing.Point(441, 30);
            this.btnFiltrarPanelCara.Name = "btnFiltrarPanelCara";
            this.btnFiltrarPanelCara.Size = new System.Drawing.Size(55, 23);
            this.btnFiltrarPanelCara.TabIndex = 4;
            this.btnFiltrarPanelCara.Text = "Filtrar";
            this.btnFiltrarPanelCara.UseVisualStyleBackColor = true;
            this.btnFiltrarPanelCara.Click += new System.EventHandler(this.btnFiltrarPanelCara_Click);
            // 
            // txtFiltrarPanelCara
            // 
            this.txtFiltrarPanelCara.Location = new System.Drawing.Point(127, 32);
            this.txtFiltrarPanelCara.Name = "txtFiltrarPanelCara";
            this.txtFiltrarPanelCara.Size = new System.Drawing.Size(299, 20);
            this.txtFiltrarPanelCara.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtrar Empleado:";
            // 
            // dgvEmpleadosCaras
            // 
            this.dgvEmpleadosCaras.AllowUserToAddRows = false;
            this.dgvEmpleadosCaras.AllowUserToDeleteRows = false;
            this.dgvEmpleadosCaras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadosCaras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColCaras});
            this.dgvEmpleadosCaras.Location = new System.Drawing.Point(39, 76);
            this.dgvEmpleadosCaras.Name = "dgvEmpleadosCaras";
            this.dgvEmpleadosCaras.ReadOnly = true;
            this.dgvEmpleadosCaras.RowHeadersWidth = 51;
            this.dgvEmpleadosCaras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosCaras.Size = new System.Drawing.Size(274, 480);
            this.dgvEmpleadosCaras.TabIndex = 0;
            this.dgvEmpleadosCaras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleadosCaras_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 170;
            // 
            // ColCaras
            // 
            this.ColCaras.HeaderText = "Caras";
            this.ColCaras.MinimumWidth = 6;
            this.ColCaras.Name = "ColCaras";
            this.ColCaras.ReadOnly = true;
            this.ColCaras.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resumen del Mes";
            // 
            // dgvMostrarATF
            // 
            this.dgvMostrarATF.AllowUserToAddRows = false;
            this.dgvMostrarATF.AllowUserToDeleteRows = false;
            this.dgvMostrarATF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarATF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEmpleado2,
            this.ColAsistencias,
            this.ColTardanzas,
            this.ColFaltas});
            this.dgvMostrarATF.Location = new System.Drawing.Point(39, 345);
            this.dgvMostrarATF.Name = "dgvMostrarATF";
            this.dgvMostrarATF.ReadOnly = true;
            this.dgvMostrarATF.RowHeadersWidth = 51;
            this.dgvMostrarATF.Size = new System.Drawing.Size(631, 210);
            this.dgvMostrarATF.TabIndex = 4;
            // 
            // ColEmpleado2
            // 
            this.ColEmpleado2.HeaderText = "Empleado";
            this.ColEmpleado2.MinimumWidth = 6;
            this.ColEmpleado2.Name = "ColEmpleado2";
            this.ColEmpleado2.ReadOnly = true;
            this.ColEmpleado2.Width = 170;
            // 
            // ColAsistencias
            // 
            this.ColAsistencias.HeaderText = "Asistencias";
            this.ColAsistencias.MinimumWidth = 6;
            this.ColAsistencias.Name = "ColAsistencias";
            this.ColAsistencias.ReadOnly = true;
            this.ColAsistencias.Width = 125;
            // 
            // ColTardanzas
            // 
            this.ColTardanzas.HeaderText = "Tardanzas";
            this.ColTardanzas.MinimumWidth = 6;
            this.ColTardanzas.Name = "ColTardanzas";
            this.ColTardanzas.ReadOnly = true;
            this.ColTardanzas.Width = 125;
            // 
            // ColFaltas
            // 
            this.ColFaltas.HeaderText = "Faltas";
            this.ColFaltas.MinimumWidth = 6;
            this.ColFaltas.Name = "ColFaltas";
            this.ColFaltas.ReadOnly = true;
            this.ColFaltas.Width = 125;
            // 
            // btnExportarMes
            // 
            this.btnExportarMes.Location = new System.Drawing.Point(411, 47);
            this.btnExportarMes.Name = "btnExportarMes";
            this.btnExportarMes.Size = new System.Drawing.Size(33, 31);
            this.btnExportarMes.TabIndex = 3;
            this.btnExportarMes.UseVisualStyleBackColor = true;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(458, 53);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(119, 21);
            this.cmbMes.TabIndex = 2;
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(583, 53);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(87, 21);
            this.cmbAno.TabIndex = 1;
            // 
            // dgvMostrarReporteDia
            // 
            this.dgvMostrarReporteDia.AllowUserToAddRows = false;
            this.dgvMostrarReporteDia.AllowUserToDeleteRows = false;
            this.dgvMostrarReporteDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarReporteDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEmpleado});
            this.dgvMostrarReporteDia.Location = new System.Drawing.Point(39, 94);
            this.dgvMostrarReporteDia.Name = "dgvMostrarReporteDia";
            this.dgvMostrarReporteDia.ReadOnly = true;
            this.dgvMostrarReporteDia.RowHeadersWidth = 51;
            this.dgvMostrarReporteDia.Size = new System.Drawing.Size(631, 179);
            this.dgvMostrarReporteDia.TabIndex = 0;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.MinimumWidth = 6;
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.ReadOnly = true;
            this.ColEmpleado.Width = 120;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 595);
            this.Controls.Add(this.panelAsistencia);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAsistencia.ResumeLayout(false);
            this.panelAsistencia.PerformLayout();
            this.panelDatosBiometricos.ResumeLayout(false);
            this.panelDatosBiometricos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarCaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosCaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarATF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReporteDia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDatosBiometricos;
        private System.Windows.Forms.Panel panelAsistencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMostrarATF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTardanzas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFaltas;
        private System.Windows.Forms.Button btnExportarMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.DataGridView dgvMostrarReporteDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado;
        private System.Windows.Forms.Panel panelDatosBiometricos;
        private System.Windows.Forms.Label lblCantidadCaras;
        private System.Windows.Forms.Label lblMostrarIniciandoCamara;
        private System.Windows.Forms.Button btnEliminarCara;
        private System.Windows.Forms.Button btnAgregarCara;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.PictureBox pbMostrarCaras;
        private System.Windows.Forms.Button btnFiltrarPanelCara;
        private System.Windows.Forms.TextBox txtFiltrarPanelCara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEmpleadosCaras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCaras;
        private System.Windows.Forms.Button btnEliminarFiltro;
    }
}
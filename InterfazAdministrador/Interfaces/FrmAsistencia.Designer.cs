namespace InterfazAdministrador.Interfaces
{
    partial class FrmAsistencia
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
            this.lblResumenMes = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarATF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReporteDia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResumenMes
            // 
            this.lblResumenMes.AutoSize = true;
            this.lblResumenMes.Location = new System.Drawing.Point(38, 312);
            this.lblResumenMes.Name = "lblResumenMes";
            this.lblResumenMes.Size = new System.Drawing.Size(158, 13);
            this.lblResumenMes.TabIndex = 11;
            this.lblResumenMes.Text = "Resumen de Asistencia del Mes";
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
            this.dgvMostrarATF.Location = new System.Drawing.Point(41, 341);
            this.dgvMostrarATF.Name = "dgvMostrarATF";
            this.dgvMostrarATF.ReadOnly = true;
            this.dgvMostrarATF.RowHeadersWidth = 51;
            this.dgvMostrarATF.Size = new System.Drawing.Size(631, 210);
            this.dgvMostrarATF.TabIndex = 10;
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
            this.btnExportarMes.Location = new System.Drawing.Point(413, 43);
            this.btnExportarMes.Name = "btnExportarMes";
            this.btnExportarMes.Size = new System.Drawing.Size(33, 31);
            this.btnExportarMes.TabIndex = 9;
            this.btnExportarMes.UseVisualStyleBackColor = true;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(460, 49);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(119, 21);
            this.cmbMes.TabIndex = 8;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(585, 49);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(87, 21);
            this.cmbAno.TabIndex = 7;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // dgvMostrarReporteDia
            // 
            this.dgvMostrarReporteDia.AllowUserToAddRows = false;
            this.dgvMostrarReporteDia.AllowUserToDeleteRows = false;
            this.dgvMostrarReporteDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarReporteDia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEmpleado});
            this.dgvMostrarReporteDia.Location = new System.Drawing.Point(41, 90);
            this.dgvMostrarReporteDia.Name = "dgvMostrarReporteDia";
            this.dgvMostrarReporteDia.ReadOnly = true;
            this.dgvMostrarReporteDia.RowHeadersWidth = 51;
            this.dgvMostrarReporteDia.Size = new System.Drawing.Size(631, 179);
            this.dgvMostrarReporteDia.TabIndex = 6;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.MinimumWidth = 6;
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.ReadOnly = true;
            this.ColEmpleado.Width = 120;
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 595);
            this.Controls.Add(this.lblResumenMes);
            this.Controls.Add(this.dgvMostrarATF);
            this.Controls.Add(this.btnExportarMes);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.dgvMostrarReporteDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsistencia";
            this.Text = "Asisyencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarATF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReporteDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumenMes;
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
    }
}
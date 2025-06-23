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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsistencia));
            this.dgvMostrarReporte = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblResumenMes = new System.Windows.Forms.Label();
            this.dgvResumen = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTardanzas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFaltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbAno = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarReporte
            // 
            this.dgvMostrarReporte.AllowUserToAddRows = false;
            this.dgvMostrarReporte.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMostrarReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMostrarReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(188)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMostrarReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMostrarReporte.ColumnHeadersHeight = 18;
            this.dgvMostrarReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMostrarReporte.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMostrarReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarReporte.Location = new System.Drawing.Point(38, 97);
            this.dgvMostrarReporte.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMostrarReporte.Name = "dgvMostrarReporte";
            this.dgvMostrarReporte.ReadOnly = true;
            this.dgvMostrarReporte.RowHeadersVisible = false;
            this.dgvMostrarReporte.RowHeadersWidth = 51;
            this.dgvMostrarReporte.RowTemplate.Height = 24;
            this.dgvMostrarReporte.Size = new System.Drawing.Size(631, 227);
            this.dgvMostrarReporte.TabIndex = 30;
            this.dgvMostrarReporte.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarReporte.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMostrarReporte.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMostrarReporte.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMostrarReporte.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMostrarReporte.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarReporte.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarReporte.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMostrarReporte.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMostrarReporte.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMostrarReporte.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMostrarReporte.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMostrarReporte.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvMostrarReporte.ThemeStyle.ReadOnly = true;
            this.dgvMostrarReporte.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMostrarReporte.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMostrarReporte.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMostrarReporte.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMostrarReporte.ThemeStyle.RowsStyle.Height = 24;
            this.dgvMostrarReporte.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMostrarReporte.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblResumenMes
            // 
            this.lblResumenMes.AutoSize = true;
            this.lblResumenMes.Font = new System.Drawing.Font("Bahnschrift", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenMes.Location = new System.Drawing.Point(35, 336);
            this.lblResumenMes.Name = "lblResumenMes";
            this.lblResumenMes.Size = new System.Drawing.Size(221, 18);
            this.lblResumenMes.TabIndex = 26;
            this.lblResumenMes.Text = "Resumen de Asistencia del Mes";
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvResumen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(188)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvResumen.ColumnHeadersHeight = 18;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ColAsistencias,
            this.ColTardanzas,
            this.ColFaltas});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumen.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvResumen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResumen.Location = new System.Drawing.Point(38, 373);
            this.dgvResumen.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.RowHeadersVisible = false;
            this.dgvResumen.RowHeadersWidth = 51;
            this.dgvResumen.RowTemplate.Height = 24;
            this.dgvResumen.Size = new System.Drawing.Size(631, 207);
            this.dgvResumen.TabIndex = 31;
            this.dgvResumen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvResumen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvResumen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvResumen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvResumen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvResumen.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvResumen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResumen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvResumen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResumen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResumen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResumen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvResumen.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvResumen.ThemeStyle.ReadOnly = true;
            this.dgvResumen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvResumen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResumen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResumen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvResumen.ThemeStyle.RowsStyle.Height = 24;
            this.dgvResumen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResumen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ColAsistencias
            // 
            this.ColAsistencias.HeaderText = "Asistencias";
            this.ColAsistencias.MinimumWidth = 6;
            this.ColAsistencias.Name = "ColAsistencias";
            this.ColAsistencias.ReadOnly = true;
            // 
            // ColTardanzas
            // 
            this.ColTardanzas.HeaderText = "Tardanzas";
            this.ColTardanzas.MinimumWidth = 6;
            this.ColTardanzas.Name = "ColTardanzas";
            this.ColTardanzas.ReadOnly = true;
            // 
            // ColFaltas
            // 
            this.ColFaltas.HeaderText = "Faltas";
            this.ColFaltas.MinimumWidth = 6;
            this.ColFaltas.Name = "ColFaltas";
            this.ColFaltas.ReadOnly = true;
            // 
            // btnExportar
            // 
            this.btnExportar.BorderRadius = 9;
            this.btnExportar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportar.FillColor = System.Drawing.Color.White;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageOffset = new System.Drawing.Point(0, 15);
            this.btnExportar.ImageSize = new System.Drawing.Size(26, 26);
            this.btnExportar.Location = new System.Drawing.Point(401, 32);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(40, 43);
            this.btnExportar.TabIndex = 32;
            this.btnExportar.Text = "btnExportar";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cmbMes
            // 
            this.cmbMes.BackColor = System.Drawing.Color.Transparent;
            this.cmbMes.BorderRadius = 12;
            this.cmbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbMes.ItemHeight = 30;
            this.cmbMes.Location = new System.Drawing.Point(460, 38);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(119, 36);
            this.cmbMes.TabIndex = 33;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // cmbAno
            // 
            this.cmbAno.BackColor = System.Drawing.Color.Transparent;
            this.cmbAno.BorderRadius = 12;
            this.cmbAno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAno.ItemHeight = 30;
            this.cmbAno.Location = new System.Drawing.Point(582, 38);
            this.cmbAno.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(88, 36);
            this.cmbAno.TabIndex = 34;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // FrmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(705, 591);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.dgvMostrarReporte);
            this.Controls.Add(this.lblResumenMes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsistencia";
            this.Text = "Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvMostrarReporte;
        private System.Windows.Forms.Label lblResumenMes;
        private Guna.UI2.WinForms.Guna2DataGridView dgvResumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTardanzas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFaltas;
        private Guna.UI2.WinForms.Guna2Button btnExportar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAno;
    }
}
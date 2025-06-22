namespace InterfazAdministrador.Interfaces
{
    partial class FrmModificar
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
            this.btnEliminarFiltro = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Location = new System.Drawing.Point(12, 44);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFiltro.TabIndex = 39;
            this.btnEliminarFiltro.Text = "EliminarFiltro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(93, 25);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(318, 20);
            this.txtFiltrar.TabIndex = 38;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Filtrar Empleado:";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(519, 24);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(93, 21);
            this.cmbMes.TabIndex = 41;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(618, 24);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(87, 21);
            this.cmbAno.TabIndex = 40;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(429, 24);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(84, 21);
            this.cmbDia.TabIndex = 42;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEmpleado,
            this.ColHoraEntrada,
            this.ColHoraSalida,
            this.ColEstado});
            this.dgvRegistro.Location = new System.Drawing.Point(12, 73);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = false;
            this.dgvRegistro.Size = new System.Drawing.Size(684, 481);
            this.dgvRegistro.TabIndex = 43;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(621, 560);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.ReadOnly = true;
            this.ColEmpleado.Width = 200;
            // 
            // ColHoraEntrada
            // 
            this.ColHoraEntrada.HeaderText = "Hora Entrada";
            this.ColHoraEntrada.Name = "ColHoraEntrada";
            this.ColHoraEntrada.ReadOnly = true;
            // 
            // ColHoraSalida
            // 
            this.ColHoraSalida.HeaderText = "Hora Salida";
            this.ColHoraSalida.Name = "ColHoraSalida";
            this.ColHoraSalida.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = false;
            this.ColEstado.Width = 120;
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 595);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificar";
            this.Text = "FrmModificar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarFiltro;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoraSalida;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColEstado;
    }
}
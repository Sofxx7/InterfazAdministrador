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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFiltrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEliminarFiltro = new Guna.UI2.WinForms.Guna2Button();
            this.dgvRegistro = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbDia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbMes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbAno = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BorderRadius = 12;
            this.txtFiltrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrar.DefaultText = "";
            this.txtFiltrar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiltrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiltrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiltrar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFiltrar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiltrar.Location = new System.Drawing.Point(139, 36);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PlaceholderText = "";
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.Size = new System.Drawing.Size(250, 29);
            this.txtFiltrar.TabIndex = 28;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(23, 39);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(116, 20);
            this.guna2HtmlLabel1.TabIndex = 27;
            this.guna2HtmlLabel1.Text = "Filtrar empleado:";
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.BorderRadius = 12;
            this.btnEliminarFiltro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarFiltro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarFiltro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarFiltro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarFiltro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(185)))), ((int)(((byte)(148)))));
            this.btnEliminarFiltro.Font = new System.Drawing.Font("Artifakt Element", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnEliminarFiltro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFiltro.Location = new System.Drawing.Point(23, 84);
            this.btnEliminarFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(116, 33);
            this.btnEliminarFiltro.TabIndex = 32;
            this.btnEliminarFiltro.Text = "Eliminar filtro";
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRegistro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(188)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistro.ColumnHeadersHeight = 18;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEmpleado,
            this.ColHoraEntrada,
            this.ColHoraSalida,
            this.ColEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegistro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistro.Location = new System.Drawing.Point(23, 141);
            this.dgvRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.RowHeadersVisible = false;
            this.dgvRegistro.RowHeadersWidth = 51;
            this.dgvRegistro.RowTemplate.Height = 24;
            this.dgvRegistro.Size = new System.Drawing.Size(662, 396);
            this.dgvRegistro.TabIndex = 33;
            this.dgvRegistro.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistro.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRegistro.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRegistro.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRegistro.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRegistro.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistro.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistro.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRegistro.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegistro.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegistro.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRegistro.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRegistro.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvRegistro.ThemeStyle.ReadOnly = false;
            this.dgvRegistro.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegistro.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistro.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegistro.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRegistro.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRegistro.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegistro.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.MinimumWidth = 6;
            this.ColEmpleado.Name = "ColEmpleado";
            // 
            // ColHoraEntrada
            // 
            this.ColHoraEntrada.HeaderText = "HoraEntrada";
            this.ColHoraEntrada.MinimumWidth = 6;
            this.ColHoraEntrada.Name = "ColHoraEntrada";
            // 
            // ColHoraSalida
            // 
            this.ColHoraSalida.HeaderText = "HoraSalida";
            this.ColHoraSalida.MinimumWidth = 6;
            this.ColHoraSalida.Name = "ColHoraSalida";
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.MinimumWidth = 6;
            this.ColEstado.Name = "ColEstado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 12;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(185)))), ((int)(((byte)(148)))));
            this.btnCancelar.Font = new System.Drawing.Font("Artifakt Element", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(492, 548);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 32);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 12;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(185)))), ((int)(((byte)(148)))));
            this.btnGuardar.Font = new System.Drawing.Font("Artifakt Element", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(592, 548);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 32);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbDia
            // 
            this.cmbDia.BackColor = System.Drawing.Color.Transparent;
            this.cmbDia.BorderRadius = 12;
            this.cmbDia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDia.ItemHeight = 30;
            this.cmbDia.Location = new System.Drawing.Point(400, 36);
            this.cmbDia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(86, 36);
            this.cmbDia.TabIndex = 46;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
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
            this.cmbMes.Location = new System.Drawing.Point(492, 36);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(86, 36);
            this.cmbMes.TabIndex = 47;
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
            this.cmbAno.Location = new System.Drawing.Point(581, 36);
            this.cmbAno.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(86, 36);
            this.cmbAno.TabIndex = 48;
            this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.cmbAno_SelectedIndexChanged);
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(705, 591);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmModificar";
            this.ShowIcon = false;
            this.Text = "FrmModificar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFiltrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnEliminarFiltro;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoraSalida;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColEstado;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDia;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMes;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAno;
    }
}
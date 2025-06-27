
namespace InterfazAdministrador.Interfaces
{
    partial class FrmTurnos
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpFin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTurnos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColRoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.BorderRadius = 12;
            this.guna2GroupBox1.Controls.Add(this.dtpFin);
            this.guna2GroupBox1.Controls.Add(this.dtpInicio);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.txtNombre);
            this.guna2GroupBox1.Controls.Add(this.btnAgregar);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.btnModificar);
            this.guna2GroupBox1.Controls.Add(this.btnEliminar);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(279, 59);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(401, 226);
            this.guna2GroupBox1.TabIndex = 52;
            // 
            // dtpFin
            // 
            this.dtpFin.BorderRadius = 12;
            this.dtpFin.Checked = true;
            this.dtpFin.CustomFormat = "HH:mm";
            this.dtpFin.FillColor = System.Drawing.Color.White;
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFin.ForeColor = System.Drawing.Color.Black;
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFin.Location = new System.Drawing.Point(80, 115);
            this.dtpFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(142, 29);
            this.dtpFin.TabIndex = 54;
            this.dtpFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpFin.Value = new System.DateTime(2025, 6, 26, 20, 39, 30, 859);
            // 
            // dtpInicio
            // 
            this.dtpInicio.BorderRadius = 12;
            this.dtpInicio.Checked = true;
            this.dtpInicio.CustomFormat = "HH:mm";
            this.dtpInicio.FillColor = System.Drawing.Color.White;
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpInicio.ForeColor = System.Drawing.Color.Black;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(80, 73);
            this.dtpInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(142, 29);
            this.dtpInicio.TabIndex = 53;
            this.dtpInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpInicio.Value = new System.DateTime(2025, 6, 26, 20, 39, 30, 859);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(20, 115);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(23, 20);
            this.guna2HtmlLabel3.TabIndex = 51;
            this.guna2HtmlLabel3.Text = "Fin";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 73);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(38, 20);
            this.guna2HtmlLabel1.TabIndex = 49;
            this.guna2HtmlLabel1.Text = "Inicio";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderRadius = 12;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(80, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(142, 29);
            this.txtNombre.TabIndex = 48;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderRadius = 12;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(185)))), ((int)(((byte)(148)))));
            this.btnAgregar.Font = new System.Drawing.Font("Artifakt Element", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(238, 24);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 35);
            this.btnAgregar.TabIndex = 44;
            this.btnAgregar.Text = "Agregar Empleado";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(20, 28);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(57, 20);
            this.guna2HtmlLabel2.TabIndex = 33;
            this.guna2HtmlLabel2.Text = "Nombre";
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 12;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(185)))), ((int)(((byte)(148)))));
            this.btnModificar.Font = new System.Drawing.Font("Artifakt Element", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(134, 164);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(88, 33);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderRadius = 12;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(185)))), ((int)(((byte)(148)))));
            this.btnEliminar.Font = new System.Drawing.Font("Artifakt Element", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(35, 164);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 33);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.AllowUserToAddRows = false;
            this.dgvTurnos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(188)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTurnos.ColumnHeadersHeight = 18;
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTurnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRoles,
            this.ColInicio,
            this.ColFin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTurnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTurnos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTurnos.Location = new System.Drawing.Point(11, 47);
            this.dgvTurnos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.ReadOnly = true;
            this.dgvTurnos.RowHeadersVisible = false;
            this.dgvTurnos.RowHeadersWidth = 51;
            this.dgvTurnos.RowTemplate.Height = 24;
            this.dgvTurnos.Size = new System.Drawing.Size(254, 443);
            this.dgvTurnos.TabIndex = 51;
            this.dgvTurnos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTurnos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTurnos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTurnos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTurnos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTurnos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTurnos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTurnos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTurnos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTurnos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTurnos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTurnos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTurnos.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvTurnos.ThemeStyle.ReadOnly = true;
            this.dgvTurnos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTurnos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTurnos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTurnos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTurnos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTurnos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTurnos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColRoles
            // 
            this.ColRoles.HeaderText = "Nombre";
            this.ColRoles.Name = "ColRoles";
            this.ColRoles.ReadOnly = true;
            // 
            // ColInicio
            // 
            this.ColInicio.HeaderText = "Inicio";
            this.ColInicio.Name = "ColInicio";
            this.ColInicio.ReadOnly = true;
            // 
            // ColFin
            // 
            this.ColFin.HeaderText = "Fin";
            this.ColFin.Name = "ColFin";
            this.ColFin.ReadOnly = true;
            // 
            // FrmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(691, 536);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgvTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTurnos";
            this.Text = "FrmTurnos";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTurnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpInicio;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFin;
    }
}
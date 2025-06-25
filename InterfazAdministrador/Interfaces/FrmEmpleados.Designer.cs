namespace InterfazAdministrador.Interfaces
{
    partial class FrmEmpleados
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTardanza = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFiltrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvEmpleado = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTardanza = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFaltas = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chartFaltas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblAsistencias = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chartAsistencias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEliminarFiltro = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTardanza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAsistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTardanza
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTardanza.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTardanza.Legends.Add(legend1);
            this.chartTardanza.Location = new System.Drawing.Point(528, 126);
            this.chartTardanza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTardanza.Name = "chartTardanza";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTardanza.Series.Add(series1);
            this.chartTardanza.Size = new System.Drawing.Size(397, 162);
            this.chartTardanza.TabIndex = 1;
            this.chartTardanza.Text = "chart2";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(45, 52);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(148, 25);
            this.guna2HtmlLabel4.TabIndex = 59;
            this.guna2HtmlLabel4.Text = "Filtrar empleado:";
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
            this.txtFiltrar.Location = new System.Drawing.Point(211, 49);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PlaceholderText = "";
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.Size = new System.Drawing.Size(555, 39);
            this.txtFiltrar.TabIndex = 58;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEmpleado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(188)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleado.ColumnHeadersHeight = 18;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEmpleado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpleado.Location = new System.Drawing.Point(45, 126);
            this.dgvEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.RowHeadersVisible = false;
            this.dgvEmpleado.RowHeadersWidth = 51;
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.Size = new System.Drawing.Size(339, 548);
            this.dgvEmpleado.TabIndex = 60;
            this.dgvEmpleado.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleado.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEmpleado.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEmpleado.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEmpleado.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEmpleado.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleado.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpleado.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvEmpleado.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleado.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpleado.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmpleado.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvEmpleado.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvEmpleado.ThemeStyle.ReadOnly = true;
            this.dgvEmpleado.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleado.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmpleado.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpleado.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmpleado.ThemeStyle.RowsStyle.Height = 24;
            this.dgvEmpleado.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEmpleado.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // ColEmpleado
            // 
            this.ColEmpleado.HeaderText = "Empleado";
            this.ColEmpleado.MinimumWidth = 6;
            this.ColEmpleado.Name = "ColEmpleado";
            this.ColEmpleado.ReadOnly = true;
            // 
            // lblTardanza
            // 
            this.lblTardanza.BackColor = System.Drawing.Color.Transparent;
            this.lblTardanza.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblTardanza.Location = new System.Drawing.Point(415, 126);
            this.lblTardanza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblTardanza.Name = "lblTardanza";
            this.lblTardanza.Size = new System.Drawing.Size(90, 25);
            this.lblTardanza.TabIndex = 61;
            this.lblTardanza.Text = "Tardanzas";
            // 
            // lblFaltas
            // 
            this.lblFaltas.BackColor = System.Drawing.Color.Transparent;
            this.lblFaltas.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblFaltas.Location = new System.Drawing.Point(415, 318);
            this.lblFaltas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(56, 25);
            this.lblFaltas.TabIndex = 62;
            this.lblFaltas.Text = "Faltas";
            // 
            // chartFaltas
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFaltas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFaltas.Legends.Add(legend2);
            this.chartFaltas.Location = new System.Drawing.Point(528, 318);
            this.chartFaltas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartFaltas.Name = "chartFaltas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFaltas.Series.Add(series2);
            this.chartFaltas.Size = new System.Drawing.Size(397, 162);
            this.chartFaltas.TabIndex = 63;
            this.chartFaltas.Text = "chart1";
            // 
            // lblAsistencias
            // 
            this.lblAsistencias.BackColor = System.Drawing.Color.Transparent;
            this.lblAsistencias.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.lblAsistencias.Location = new System.Drawing.Point(415, 512);
            this.lblAsistencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblAsistencias.Name = "lblAsistencias";
            this.lblAsistencias.Size = new System.Drawing.Size(101, 25);
            this.lblAsistencias.TabIndex = 64;
            this.lblAsistencias.Text = "Asistencias";
            // 
            // chartAsistencias
            // 
            chartArea3.Name = "ChartArea1";
            this.chartAsistencias.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartAsistencias.Legends.Add(legend3);
            this.chartAsistencias.Location = new System.Drawing.Point(528, 512);
            this.chartAsistencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartAsistencias.Name = "chartAsistencias";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartAsistencias.Series.Add(series3);
            this.chartAsistencias.Size = new System.Drawing.Size(397, 162);
            this.chartAsistencias.TabIndex = 65;
            this.chartAsistencias.Text = "chart3";
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
            this.btnEliminarFiltro.Location = new System.Drawing.Point(771, 49);
            this.btnEliminarFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(155, 36);
            this.btnEliminarFiltro.TabIndex = 66;
            this.btnEliminarFiltro.Text = "Eliminar filtro";
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(940, 708);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.chartAsistencias);
            this.Controls.Add(this.lblAsistencias);
            this.Controls.Add(this.chartFaltas);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.lblTardanza);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.chartTardanza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.chartTardanza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFaltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTardanza;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleado;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTardanza;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFaltas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFaltas;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAsistencias;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAsistencias;
        private Guna.UI2.WinForms.Guna2Button btnEliminarFiltro;
    }
}
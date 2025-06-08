namespace InterfazAdministrador.Interfaces
{
    partial class FrmDatosBiometricos
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
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarCaras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosCaras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarFiltro
            // 
            this.btnEliminarFiltro.Location = new System.Drawing.Point(504, 34);
            this.btnEliminarFiltro.Name = "btnEliminarFiltro";
            this.btnEliminarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFiltro.TabIndex = 24;
            this.btnEliminarFiltro.Text = "EliminarFiltro";
            this.btnEliminarFiltro.UseVisualStyleBackColor = true;
            this.btnEliminarFiltro.Click += new System.EventHandler(this.btnEliminarFiltro_Click);
            // 
            // lblCantidadCaras
            // 
            this.lblCantidadCaras.AutoSize = true;
            this.lblCantidadCaras.ForeColor = System.Drawing.Color.Blue;
            this.lblCantidadCaras.Location = new System.Drawing.Point(494, 376);
            this.lblCantidadCaras.Name = "lblCantidadCaras";
            this.lblCantidadCaras.Size = new System.Drawing.Size(35, 13);
            this.lblCantidadCaras.TabIndex = 23;
            this.lblCantidadCaras.Text = "label3";
            // 
            // lblMostrarIniciandoCamara
            // 
            this.lblMostrarIniciandoCamara.AutoSize = true;
            this.lblMostrarIniciandoCamara.ForeColor = System.Drawing.Color.Red;
            this.lblMostrarIniciandoCamara.Location = new System.Drawing.Point(350, 454);
            this.lblMostrarIniciandoCamara.Name = "lblMostrarIniciandoCamara";
            this.lblMostrarIniciandoCamara.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarIniciandoCamara.TabIndex = 22;
            this.lblMostrarIniciandoCamara.Text = "label3";
            // 
            // btnEliminarCara
            // 
            this.btnEliminarCara.Location = new System.Drawing.Point(522, 413);
            this.btnEliminarCara.Name = "btnEliminarCara";
            this.btnEliminarCara.Size = new System.Drawing.Size(103, 23);
            this.btnEliminarCara.TabIndex = 21;
            this.btnEliminarCara.Text = "Eliminar Cara";
            this.btnEliminarCara.UseVisualStyleBackColor = true;
            this.btnEliminarCara.Click += new System.EventHandler(this.btnEliminarCara_Click);
            // 
            // btnAgregarCara
            // 
            this.btnAgregarCara.Location = new System.Drawing.Point(393, 413);
            this.btnAgregarCara.Name = "btnAgregarCara";
            this.btnAgregarCara.Size = new System.Drawing.Size(105, 23);
            this.btnAgregarCara.TabIndex = 20;
            this.btnAgregarCara.Text = "Agregar Cara";
            this.btnAgregarCara.UseVisualStyleBackColor = true;
            this.btnAgregarCara.Click += new System.EventHandler(this.btnAgregarCara_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(567, 371);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = ">>";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(380, 371);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "<<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // pbMostrarCaras
            // 
            this.pbMostrarCaras.Location = new System.Drawing.Point(353, 80);
            this.pbMostrarCaras.Name = "pbMostrarCaras";
            this.pbMostrarCaras.Size = new System.Drawing.Size(320, 274);
            this.pbMostrarCaras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrarCaras.TabIndex = 17;
            this.pbMostrarCaras.TabStop = false;
            // 
            // btnFiltrarPanelCara
            // 
            this.btnFiltrarPanelCara.Location = new System.Drawing.Point(443, 34);
            this.btnFiltrarPanelCara.Name = "btnFiltrarPanelCara";
            this.btnFiltrarPanelCara.Size = new System.Drawing.Size(55, 23);
            this.btnFiltrarPanelCara.TabIndex = 16;
            this.btnFiltrarPanelCara.Text = "Filtrar";
            this.btnFiltrarPanelCara.UseVisualStyleBackColor = true;
            this.btnFiltrarPanelCara.Click += new System.EventHandler(this.btnFiltrarPanelCara_Click);
            // 
            // txtFiltrarPanelCara
            // 
            this.txtFiltrarPanelCara.Location = new System.Drawing.Point(129, 36);
            this.txtFiltrarPanelCara.Name = "txtFiltrarPanelCara";
            this.txtFiltrarPanelCara.Size = new System.Drawing.Size(299, 20);
            this.txtFiltrarPanelCara.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
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
            this.dgvEmpleadosCaras.Location = new System.Drawing.Point(41, 80);
            this.dgvEmpleadosCaras.Name = "dgvEmpleadosCaras";
            this.dgvEmpleadosCaras.ReadOnly = true;
            this.dgvEmpleadosCaras.RowHeadersWidth = 51;
            this.dgvEmpleadosCaras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleadosCaras.Size = new System.Drawing.Size(274, 480);
            this.dgvEmpleadosCaras.TabIndex = 13;
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
            // DatatosBiometricos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 595);
            this.Controls.Add(this.btnEliminarFiltro);
            this.Controls.Add(this.lblCantidadCaras);
            this.Controls.Add(this.lblMostrarIniciandoCamara);
            this.Controls.Add(this.btnEliminarCara);
            this.Controls.Add(this.btnAgregarCara);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pbMostrarCaras);
            this.Controls.Add(this.btnFiltrarPanelCara);
            this.Controls.Add(this.txtFiltrarPanelCara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEmpleadosCaras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatatosBiometricos";
            this.Text = "DatatosBiometricos";
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarCaras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadosCaras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarFiltro;
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
    }
}
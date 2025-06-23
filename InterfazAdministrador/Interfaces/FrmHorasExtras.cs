using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazAdministrador.Data;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmHorasExtras : Form
    {
        private List<Empleado> empleados;
        private Empleado empleadoSeleccionado;
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly FechaRepository fechaRepository = new FechaRepository();
        private readonly DataClassesTableDataContext db = new DataClassesTableDataContext();

        public FrmHorasExtras()
        {
            InitializeComponent();
            this.Load += FrmHorasExtras_Load1;
            gbHorasExtras.Enabled = false;
            txtNombre.Enabled = false;
        }

        private void FrmHorasExtras_Load1(object sender, EventArgs e)
        {
            llenarDGVEmpleados(empleados);
        }

        private void btnEliminarFil_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = string.Empty;
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = empleados;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtFiltrar.Text.ToLower();

            if (string.IsNullOrEmpty(buscar)) return;

            List<Empleado> empleadosFiltrados = empleados
                .Where(emp => emp.nombreEmpleado.ToLower().Contains(buscar) || emp.apellidoEmpleado.ToLower().Contains(buscar))
                .ToList();

            llenarDGVEmpleados(empleadosFiltrados);
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila >= 0 && fila < dgvEmpleados.Rows.Count)
            {
                gbHorasExtras.Enabled = true;

                string nombreCompleto = dgvEmpleados.Rows[fila].Cells[0].Value.ToString();

                empleadoSeleccionado = empleados.Single(emp => $"{emp.apellidoEmpleado}, {emp.nombreEmpleado}".Equals(nombreCompleto));
                if (empleadoSeleccionado == null) MessageBox.Show("Error al obtener al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNombre.Text = empleadoSeleccionado.nombreEmpleado;
                
            }
        }

        private void llenarDGVEmpleados(List<Empleado> empls)
        {
            dgvEmpleados.Rows.Clear();
            foreach (var empleado in empls)
            {
                dgvEmpleados.Rows.Add($"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}");
            }
        }

        private void btnAgregarHorasExtras_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;

            if (!int.TryParse(txtHorasExtras.Text, out int horas) || horas <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var idfecha = fechaRepository.ObtenerIDPorFecha(DateTime.Now);

            HoraExtra nuevaHoraExtra = new HoraExtra
            {
                idEmpleado = empleado.idEmpleado,
                idFecha = idfecha,
                minutosHorasExtras = horas
            };

            db.HoraExtra.InsertOnSubmit(nuevaHoraExtra);
            db.SubmitChanges();

            MessageBox.Show("Horas extras añadidas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

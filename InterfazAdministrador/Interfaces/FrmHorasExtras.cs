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
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly FechaRepository fechaRepository = new FechaRepository();
        private readonly HoraExtraRepository horaExtraRepository = new HoraExtraRepository();

        private List<Empleado> empleados;
        private Empleado empleadoSeleccionado;

        public FrmHorasExtras()
        {
            InitializeComponent();
            this.Load += FrmHorasExtras_Load1;
        }

        private async void FrmHorasExtras_Load1(object sender, EventArgs e)
        {
            await CargarDatosAsync();
        }

        private async Task CargarDatosAsync()
        {
            try
            {
                empleados = await Task.Run(() => empleadoRepository.ListarEmpleados());
                if (empleados == null || empleados.Count == 0)
                {
                    MessageBox.Show("No hay empleados registrados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    gbHorasExtras.Enabled = false;
                    return;
                }
                gbHorasExtras.Enabled = false;
                txtNombre.Enabled = false;
                llenarDGVEmpleados(empleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gbHorasExtras.Enabled = false;
            }
        }

        private void btnEliminarFil_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = string.Empty;
            llenarDGVEmpleados(empleados);
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtFiltrar.Text.ToLower();

            if (string.IsNullOrEmpty(buscar))
            {
                llenarDGVEmpleados(empleados);
                return;
            }

            List<Empleado> empleadosFiltrados = empleados
                .Where(emp => emp.nombreEmpleado.ToLower().Contains(buscar) || emp.apellidoEmpleado.ToLower().Contains(buscar))
                .ToList();

            if (empleadosFiltrados.Count == 0)
            {
                MessageBox.Show("No se encontraron empleados con ese filtro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEmpleados.Rows.Clear();
                gbHorasExtras.Enabled = false;
                return;
            }

            llenarDGVEmpleados(empleadosFiltrados);
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila >= 0 && fila < dgvEmpleados.Rows.Count)
            {
                gbHorasExtras.Enabled = true;
                var cellValue = dgvEmpleados.Rows[fila].Cells[0].Value;
                if (cellValue == null)
                {
                    MessageBox.Show("No se pudo obtener el nombre del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gbHorasExtras.Enabled = false;
                    txtNombre.Text = string.Empty;
                    return;
                }
                string nombreCompleto = cellValue.ToString();
                var empleado = empleados.FirstOrDefault(emp => $"{emp.apellidoEmpleado}, {emp.nombreEmpleado}".Equals(nombreCompleto));
                if (empleado == null)
                {
                    MessageBox.Show("Error al obtener al empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gbHorasExtras.Enabled = false;
                    txtNombre.Text = string.Empty;
                    return;
                }
                empleadoSeleccionado = empleado;
                txtNombre.Text = empleadoSeleccionado.nombreEmpleado;
            }
        }

        private void llenarDGVEmpleados(List<Empleado> empls)
        {
            dgvEmpleados.Rows.Clear();

            var idfecha = fechaRepository.ObtenerIDPorFecha(DateTime.Now);

            foreach (var emp in empls)
            {
                int totalHorasExtras = horaExtraRepository
                    .ObtenerHorasExtrasPorEmpleado(emp.idEmpleado, idfecha);

                dgvEmpleados.Rows.Add(
                    $"{emp.apellidoEmpleado}, {emp.nombreEmpleado}",
                    totalHorasExtras / 60
                );
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtHorasExtras.Text, out int horas) || horas <= 0 || horas > 2)
            {
                MessageBox.Show("Ingrese una cantidad válida de horas (1 o 2).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var idfecha = fechaRepository.ObtenerIDPorFecha(DateTime.Now);

                if (idfecha <= 0)
                {
                    MessageBox.Show("No se pudo obtener la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HoraExtra nuevaHoraExtra = new HoraExtra
                {
                    idEmpleado = empleadoSeleccionado.idEmpleado,
                    idFecha = idfecha,
                    minutosHorasExtras = horas * 60
                };

                if (horaExtraRepository.InsertarHoraExtra(nuevaHoraExtra))
                {
                    MessageBox.Show("Horas extras añadidas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarDatosAsync();
                    txtHorasExtras.Text = "";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar las horas extras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar horas extras: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using InterfazAdministrador.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmModificar : Form
    {
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly FechaRepository fechaRepository = new FechaRepository();
        private readonly EstadoAsistenciaRepository estadoRepository = new EstadoAsistenciaRepository();
        private readonly RegistroDiarioRepository registroRepository = new RegistroDiarioRepository();
        private List<Fecha> fechasCache;
        private List<EstadoAsistencia> estadosAsistencia;
        private List<Empleado> empleados;

        public FrmModificar()
        {
            InitializeComponent();
            this.Load += FrmModificar_LoadAsync;
        }

        private async void FrmModificar_LoadAsync(object sender, EventArgs e)
        {
            await CargarDatosInicialesAsync();
        }

        private async Task CargarDatosInicialesAsync()
        {
            try
            {
                var fechasTask = Task.Run(() => fechaRepository.ObtenerFechas());
                var estadosTask = Task.Run(() => estadoRepository.ListarEstadoAsistencia());
                var empleadosTask = Task.Run(() => empleadoRepository.ListarEmpleados());
                fechasCache = await fechasTask;
                estadosAsistencia = await estadosTask;
                empleados = await empleadosTask;
                if (fechasCache == null || fechasCache.Count == 0)
                {
                    MessageBox.Show("No hay fechas registradas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (estadosAsistencia == null || estadosAsistencia.Count == 0)
                {
                    MessageBox.Show("No hay estados de asistencia registrados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (empleados == null || empleados.Count == 0)
                {
                    MessageBox.Show("No hay empleados registrados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CargarComboBoxes();
                ConfigurarDgvRegistro();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos iniciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxes()
        {
            cmbAno.SelectedIndexChanged -= cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged -= cmbMes_SelectedIndexChanged;

            var anos = fechasCache.Select(f => f.ano).Distinct().OrderBy(y => y).ToList();
            cmbAno.DataSource = anos;
            if (anos.Any())
            {
                cmbAno.SelectedIndex = anos.IndexOf(DateTime.Now.Year.ToString());
            }
            else
            {
                cmbAno.SelectedIndex = -1;
            }

            CargarMesesPorAnoSeleccionado();
            LoadDaysForSelectedMonthAndYear();

            cmbAno.SelectedIndexChanged += cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
        }

        private void CargarMesesPorAnoSeleccionado()
        {
            cmbMes.SelectedIndexChanged -= cmbMes_SelectedIndexChanged;
            cmbDia.SelectedIndexChanged -= cmbDia_SelectedIndexChanged;

            if (cmbAno.SelectedItem == null) return;
            string anoSeleccionado = cmbAno.SelectedItem.ToString();
            var meses = fechasCache
                .Where(f => f.ano == anoSeleccionado)
                .Select(f => f.mes)
                .Distinct()
                .OrderBy(m => int.Parse(m))
                .ToList();
            cmbMes.DataSource = meses;
            if (meses.Any())
            {
                string mesActual = DateTime.Now.Month.ToString("D2");
                int idx = meses.IndexOf(mesActual);
                cmbMes.SelectedIndex = idx >= 0 ? idx : meses.Count - 1;
            }
            else
            {
                cmbMes.SelectedIndex = -1;
            }

            LoadDaysForSelectedMonthAndYear();

            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
            cmbDia.SelectedIndexChanged += cmbDia_SelectedIndexChanged;
        }

        private void LoadDaysForSelectedMonthAndYear()
        {
            cmbDia.SelectedIndexChanged -= cmbDia_SelectedIndexChanged;
            if (cmbAno.SelectedItem == null || cmbMes.SelectedItem == null) return;
            string anoSeleccionado = cmbAno.SelectedItem.ToString();
            string mesSeleccionado = cmbMes.SelectedItem.ToString();
            var dias = fechasCache
                .Where(f => f.ano == anoSeleccionado && f.mes == mesSeleccionado)
                .Select(f => f.dia)
                .Distinct()
                .OrderBy(d => int.Parse(d))
                .ToList();
            cmbDia.DataSource = dias;
            if (dias.Any())
            {
                string currentDay = DateTime.Now.Day.ToString("D2");
                int idx = dias.IndexOf(currentDay);
                cmbDia.SelectedIndex = idx >= 0 ? idx : dias.Count - 1;
            }
            else
            {
                cmbDia.SelectedIndex = -1;
            }
            cmbDia.SelectedIndexChanged += cmbDia_SelectedIndexChanged;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtFiltrar.Text.ToLower();
            if (cmbAno.SelectedItem == null || cmbMes.SelectedItem == null || cmbDia.SelectedItem == null)
                return;
            string anoSeleccionado = cmbAno.SelectedItem.ToString();
            string mesSeleccionado = cmbMes.SelectedItem.ToString();
            string diaSeleccionado = cmbDia.SelectedItem.ToString();
            List<RegistroDiario> registros = registroRepository.ListarRegistrosDiariosPorFecha(diaSeleccionado, mesSeleccionado, anoSeleccionado);
            dgvRegistro.Rows.Clear();
            int i = 0;
            bool hayResultados = false;
            foreach (var registro in registros)
            {
                var empleado = empleadoRepository.ObtenerEmpleadoPorId(registro.idEmpleado);
                if (empleado == null) continue;
                string nombreCompleto = $"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}";
                if (!string.IsNullOrEmpty(buscar))
                {
                    if (!(empleado.nombreEmpleado.ToLower().Contains(buscar) || empleado.apellidoEmpleado.ToLower().Contains(buscar)))
                        continue;
                }
                var estadoAsistenciaLocal = estadosAsistencia.FirstOrDefault(x => x.idEvento == registro.estadoAsistencia);
                dgvRegistro.Rows.Add(
                    nombreCompleto,
                    registro.horaEntrada,
                    registro.horaSalida,
                    estadoAsistenciaLocal != null ? estadoAsistenciaLocal.idEvento : (object)null
                );
                i++;
                hayResultados = true;
            }
            if (!hayResultados)
            {
                MessageBox.Show("No se encontraron empleados con ese filtro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRegistro.Rows.Clear();
            }
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMesesPorAnoSeleccionado();
            ActualizarRegistros();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDaysForSelectedMonthAndYear();
            ActualizarRegistros();
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarRegistros();
        }

        private void ActualizarRegistros()
        {
            dgvRegistro.Rows.Clear();
            if (cmbAno.SelectedItem == null || cmbMes.SelectedItem == null || cmbDia.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un año, mes y día válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string anoSeleccionado = cmbAno.SelectedItem.ToString();
            string mesSeleccionado = cmbMes.SelectedItem.ToString();
            string diaSeleccionado = cmbDia.SelectedItem.ToString();
            List<RegistroDiario> registros = registroRepository.ListarRegistrosDiariosPorFecha(diaSeleccionado, mesSeleccionado, anoSeleccionado);
            if (registros == null || registros.Count == 0)
            {
                MessageBox.Show("No se encontraron registros para la fecha seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int i = 0;
            foreach (var registro in registros)
            {
                var empleado = empleadoRepository.ObtenerEmpleadoPorId(registro.idEmpleado);
                if (empleado == null) continue;
                var estado = estadosAsistencia.FirstOrDefault(e => e.idEvento == registro.estadoAsistencia);
                dgvRegistro.Rows.Add(
                    $"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}",
                    registro.horaEntrada,
                    registro.horaSalida,
                    estado != null ? estado.idEvento : (object)null
                );
                i++;
            }
        }

        private void ConfigurarDgvRegistro()
        {
            var colEstado = dgvRegistro.Columns["ColEstado"] as DataGridViewComboBoxColumn;
            if (colEstado != null)
            {
                colEstado.DataSource = estadosAsistencia;
                colEstado.DisplayMember = "nombreEvento";
                colEstado.ValueMember = "idEvento";
            }
            dgvRegistro.EditingControlShowing += dgvRegistro_EditingControlShowing;
        }

        private void dgvRegistro_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvRegistro.CurrentCell.ColumnIndex == dgvRegistro.Columns["ColEstado"].Index)
            {
                var combo = e.Control as ComboBox;
                if (combo != null)
                {

                    int rowIndex = dgvRegistro.CurrentCell.RowIndex;
                    var estadoActual = dgvRegistro.Rows[rowIndex].Cells["ColEstado"].Value;
                    var estadoObj = estadosAsistencia.FirstOrDefault(es => es.idEvento.Equals(estadoActual));
                    if (estadoObj != null && (estadoObj.nombreEvento == "Tardanza" || estadoObj.nombreEvento == "Falta"))
                    {
                        combo.Enabled = true;
                        var justificado = estadosAsistencia.FirstOrDefault(es => es.nombreEvento == "Justificado");
                        var items = new List<EstadoAsistencia> { estadoObj };
                        if (justificado != null && estadoObj.idEvento != justificado.idEvento)
                            items.Add(justificado);
                        combo.DataSource = items;
                        combo.DisplayMember = "nombreEvento";
                        combo.ValueMember = "idEvento";
                    }
                    else
                    {
                        combo.DataSource = estadoObj != null ? new List<EstadoAsistencia> { estadoObj } : new List<EstadoAsistencia>();
                        combo.DisplayMember = "nombreEvento";
                        combo.ValueMember = "idEvento";
                        combo.Enabled = false;
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea descartar los cambios?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ActualizarRegistros();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbAno.SelectedItem == null || cmbMes.SelectedItem == null || cmbDia.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un año, mes y día válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ano = cmbAno.SelectedItem.ToString();
            string mes = cmbMes.SelectedItem.ToString();
            string dia = cmbDia.SelectedItem.ToString();
            bool huboCambios = false;
            for (int i = 0; i < dgvRegistro.Rows.Count; i++)
            {
                var row = dgvRegistro.Rows[i];
                var nuevoEstado = row.Cells["ColEstado"].Value;
                if ((nuevoEstado == null) || (nuevoEstado != null))
                {
                    var empleadoNombre = row.Cells["ColEmpleado"].Value?.ToString();
                    if (string.IsNullOrEmpty(empleadoNombre)) continue;
                    var partes = empleadoNombre.Split(',');
                    if (partes.Length < 2) continue;
                    string apellido = partes[0].Trim();
                    string nombre = partes[1].Trim();
                    var empleado = empleadoRepository.BuscarEmpleadoPorNombre(apellido, nombre);
                    if (empleado == null) continue;
                    int idEstado;
                    if (!int.TryParse(nuevoEstado?.ToString(), out idEstado)) continue;
                    bool actualizado = registroRepository.ActualizarEstadoAsistencia(empleado.idEmpleado, dia, mes, ano, idEstado);
                    if (!actualizado)
                    {
                        MessageBox.Show($"No se pudo actualizar el registro de {empleadoNombre}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        huboCambios = true;
                    }
                }
            }
            if (huboCambios)
            {
                MessageBox.Show("Cambios guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarRegistros();
            }
            else
            {
                MessageBox.Show("No hay cambios para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = string.Empty;
            ActualizarRegistros();
        }
    }
}

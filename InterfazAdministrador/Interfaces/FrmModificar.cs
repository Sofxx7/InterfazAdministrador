using InterfazAdministrador.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private bool _evitandoEvento = false;
        private Dictionary<int, object> estadosOriginales = new Dictionary<int, object>();

        public FrmModificar()
        {
            InitializeComponent();

            fechasCache = fechaRepository.ObtenerFechas();
            estadosAsistencia = estadoRepository.ListarEstadoAsistencia();
            LoadComboBoxes();
            ConfigurarDgvRegistro();
        }

        private void LoadComboBoxes()
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

            LoadMonthsForSelectedYear();
            LoadDaysForSelectedMonthAndYear();

            cmbAno.SelectedIndexChanged += cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
        }

        private void LoadMonthsForSelectedYear()
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
            if (string.IsNullOrEmpty(buscar)) return;
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarRegistros();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDaysForSelectedMonthAndYear();
            ActualizarRegistros();
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonthsForSelectedYear();
            ActualizarRegistros();
        }

        private void ActualizarRegistros()
        {
            _evitandoEvento = true;
            dgvRegistro.Rows.Clear();
            estadosOriginales.Clear();
            if (cmbAno.SelectedItem == null || cmbMes.SelectedItem == null || cmbDia.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un año, mes y día válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _evitandoEvento = false;
                return;
            }

            string anoSeleccionado = cmbAno.SelectedItem.ToString();
            string mesSeleccionado = cmbMes.SelectedItem.ToString();
            string diaSeleccionado = cmbDia.SelectedItem.ToString();

            List<RegistroDiario> registros = registroRepository.ListarRegistrosDiariosPorFecha(diaSeleccionado, mesSeleccionado, anoSeleccionado);
            if (registros.Count == 0)
            {
                MessageBox.Show("No se encontraron registros para la fecha seleccionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _evitandoEvento = false;
                return;
            }
            int i = 0;
            foreach (var registro in registros)
            {
                var empleado = empleadoRepository.ObtenerEmpleadoPorId(registro.idEmpleado);
                var estado = estadosAsistencia.FirstOrDefault(e => e.idEvento == registro.idEstadoAsistencia);
                dgvRegistro.Rows.Add(
                    $"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}",
                    registro.horaEntrada,
                    registro.horaSalida,
                    estado != null ? estado.idEvento : (object)null
                );
                estadosOriginales[i] = estado != null ? estado.idEvento : (object)null;
                i++;
            }
            _evitandoEvento = false;
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
                    // Solo permitir cambio si el estado es Tardanza o Falta
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
                        // Solo mostrar el estado actual y deshabilitar edición
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
                var originalEstado = estadosOriginales.ContainsKey(i) ? estadosOriginales[i] : null;
                if ((nuevoEstado == null && originalEstado != null) || (nuevoEstado != null && !nuevoEstado.Equals(originalEstado)))
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
    }
}

using InterfazAdministrador.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmEmpleados : Form
    {
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly FechaRepository fechaRepository = new FechaRepository();
        private readonly RegistroDiarioRepository registroDiarioRepository = new RegistroDiarioRepository();

        private Empleado empleadoSeleccionado;
        private List<Empleado> empleados;
        private List<Fecha> fechas;
        private List<RegistroDiario> registroDiarios;

        public FrmEmpleados()
        {
            InitializeComponent();
            this.Load += FrmEmpleados_Load;
        }

        private async void FrmEmpleados_Load(object sender, EventArgs e)
        {
            await CargarDatosInicialesAsync();
        }

        private async Task CargarDatosInicialesAsync()
        {
            try
            {
                var empleadosTask = System.Threading.Tasks.Task.Run(() => empleadoRepository.ListarEmpleados());
                var fechasTask = System.Threading.Tasks.Task.Run(() => fechaRepository.ObtenerFechas());
                var registrosTask = System.Threading.Tasks.Task.Run(() => registroDiarioRepository.ListarRegistrosDiarios());
                empleados = await empleadosTask;
                fechas = await fechasTask;
                registroDiarios = await registrosTask;
                if (empleados == null || empleados.Count == 0)
                {
                    MessageBox.Show("No hay empleados registrados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InterfacesColocar(false);
                    return;
                }
                if (fechas == null || fechas.Count == 0)
                {
                    MessageBox.Show("No hay fechas registradas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InterfacesColocar(false);
                    return;
                }
                if (registroDiarios == null)
                {
                    MessageBox.Show("No se pudieron cargar los registros diarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InterfacesColocar(false);
                    return;
                }
                InterfacesColocar(false);
                llenarDGVEmpleados(empleados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos iniciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InterfacesColocar(false);
            }
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
                dgvEmpleado.Rows.Clear();
                InterfacesColocar(false);
                return;
            }
            llenarDGVEmpleados(empleadosFiltrados);
        }

        private void btnEliminarFiltro_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = string.Empty;
            llenarDGVEmpleados(empleados);
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            chartAsistencias.Series.Clear();
            chartTardanza.Series.Clear();
            chartFaltas.Series.Clear();

            int fila = e.RowIndex;

            if (fila >= 0 && fila < dgvEmpleado.Rows.Count)
            {
                var cellValue = dgvEmpleado.Rows[fila].Cells[0].Value;
                if (cellValue == null)
                {
                    MessageBox.Show("No se pudo obtener el nombre del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InterfacesColocar(false);
                    return;
                }
                string nombreCompleto = cellValue.ToString();
                var empleado = empleados.FirstOrDefault(emp => $"{emp.apellidoEmpleado}, {emp.nombreEmpleado}".Equals(nombreCompleto));
                if (empleado == null)
                {
                    MessageBox.Show("Error al obtener al empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InterfacesColocar(false);
                    return;
                }
                empleadoSeleccionado = empleado;
                InterfacesColocar(true);
                MostrarGraficoTardanzaPorMes(empleadoSeleccionado.idEmpleado);
                MostrarGraficoFaltasPorMes(empleadoSeleccionado.idEmpleado);
                MostrarGraficoAsistenciasPorMes(empleadoSeleccionado.idEmpleado);
            }
            else
            {
                InterfacesColocar(false);
            }
        }

        private void MostrarGraficoAsistenciasPorMes(string idEmpleado)
        {
            chartAsistencias.Series.Clear();
            var serie = chartAsistencias.Series.Add("Asistencias por mes");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            int anioActual = DateTime.Now.Year;
            var mesesDisponibles = fechaRepository.ObtenerLosMesesPorAno(anioActual.ToString())
                .Select(m => int.Parse(m)).ToList();

            var asistenciasPorMes = mesesDisponibles.ToDictionary(m => m, m => 0);

            var registrosEmpleado = registroDiarios
                .Where(r => r.idEmpleado == idEmpleado && r.estadoAsistencia == 1)
                .ToList();

            var registrosConFecha = registrosEmpleado
                .Join(
                    fechas,
                    reg => reg.idFecha,
                    f => f.idFecha,
                    (reg, f) => new { Fecha = f }
                )
                .Where(x => x.Fecha.ano == anioActual.ToString())
                .ToList();

            foreach (var item in registrosConFecha)
            {
                if (int.TryParse(item.Fecha.mes, out int mes) && asistenciasPorMes.ContainsKey(mes))
                {
                    asistenciasPorMes[mes]++;
                }
            }

            foreach (var mes in mesesDisponibles)
            {
                string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mes);
                serie.Points.AddXY(nombreMes, asistenciasPorMes[mes]);
            }
        }

        private void MostrarGraficoTardanzaPorMes(string idEmpleado)
        {
            chartTardanza.Series.Clear();
            var serie = chartTardanza.Series.Add("Tardanzas por mes");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            int anioActual = DateTime.Now.Year;
            var mesesDisponibles = fechaRepository.ObtenerLosMesesPorAno(anioActual.ToString())
                .Select(m => int.Parse(m)).ToList();

            var tardanzasPorMes = mesesDisponibles.ToDictionary(m => m, m => 0);

            var registrosEmpleado = registroDiarios
                .Where(r => r.idEmpleado == idEmpleado && r.estadoAsistencia == 2)
                .ToList();

            var registrosConFecha = registrosEmpleado
                .Join(
                    fechas,
                    reg => reg.idFecha,
                    f => f.idFecha,
                    (reg, f) => new { Fecha = f }
                )
                .Where(x => x.Fecha.ano == anioActual.ToString())
                .ToList();

            foreach (var item in registrosConFecha)
            {
                if (int.TryParse(item.Fecha.mes, out int mes) && tardanzasPorMes.ContainsKey(mes))
                {
                    tardanzasPorMes[mes]++;
                }
            }

            foreach (var mes in mesesDisponibles)
            {
                string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mes);
                serie.Points.AddXY(nombreMes, tardanzasPorMes[mes]);
            }
        }

        private void MostrarGraficoFaltasPorMes(string idEmpleado)
        {
            chartFaltas.Series.Clear();
            var serie = chartFaltas.Series.Add("Faltas por mes");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            int anioActual = DateTime.Now.Year;
            var mesesDisponibles = fechaRepository.ObtenerLosMesesPorAno(anioActual.ToString())
                .Select(m => int.Parse(m)).ToList();

            var faltasPorMes = mesesDisponibles.ToDictionary(m => m, m => 0);

            var registrosEmpleado = registroDiarios
                .Where(r => r.idEmpleado == idEmpleado && r.estadoAsistencia == 3)
                .ToList();

            var registrosConFecha = registrosEmpleado
                .Join(
                    fechas,
                    reg => reg.idFecha,
                    f => f.idFecha,
                    (reg, f) => new { Fecha = f }
                )
                .Where(x => x.Fecha.ano == anioActual.ToString())
                .ToList();

            foreach (var item in registrosConFecha)
            {
                if (int.TryParse(item.Fecha.mes, out int mes) && faltasPorMes.ContainsKey(mes))
                {
                    faltasPorMes[mes]++;
                }
            }

            foreach (var mes in mesesDisponibles)
            {
                string nombreMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mes);
                serie.Points.AddXY(nombreMes, faltasPorMes[mes]);
            }
        }

        private void llenarDGVEmpleados(List<Empleado> empleados)
        {
            dgvEmpleado.Rows.Clear();
            foreach (var empleado in empleados)
            {
                dgvEmpleado.Rows.Add($"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}");
            }
        }

        private void InterfacesColocar(bool estado)
        {
            lblTardanza.Visible = estado;
            chartTardanza.Visible = estado;

            lblFaltas.Visible = estado;
            chartFaltas.Visible = estado;

            lblAsistencias.Visible = estado;
            chartAsistencias.Visible = estado;
        }
    }
}

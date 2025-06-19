using InterfazAdministrador.Data;
using InterfazAdministrador.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmAsistencia : Form
    {
        private readonly FechaRepository fechaRepository = new FechaRepository();
        private readonly EmpleadoRepository empleadoRepository = new EmpleadoRepository();
        private readonly RegistroDiarioRepository registroDiarioRepository = new RegistroDiarioRepository();
        private readonly EstadoAsistenciaRepository estadoAsistenciaRepository = new EstadoAsistenciaRepository();
        private readonly Tool tool = new Tool();

        private int actualMonth;
        private string actualYear;

        private List<Empleado> empleadosCache;
        private List<EstadoAsistencia> estadosAsistenciaCache;

        public FrmAsistencia()
        {
            InitializeComponent();
            empleadosCache = empleadoRepository.ListarEmpleados();
            estadosAsistenciaCache = estadoAsistenciaRepository.ListarEstadoAsistencia();
            LoadComboBoxes();
            CargarDgvReporteDia();
            CargarDgvATF();
        }

        private void LoadComboBoxes()
        {
            cmbAno.SelectedIndexChanged -= cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged -= cmbMes_SelectedIndexChanged;

            DateTime currentDate = DateTime.Now;
            actualMonth = currentDate.Month;
            actualYear = currentDate.Year.ToString();

            var years = fechaRepository.ObtenerLosAnos();
            if (years != null && years.Any())
            {
                cmbAno.DataSource = years;

                if (years.Contains(actualYear))
                {
                    cmbAno.SelectedItem = actualYear;
                }
                else
                {
                    cmbAno.SelectedIndex = cmbAno.Items.Count - 1;
                    actualYear = cmbAno.SelectedItem?.ToString() ?? actualYear;
                }
            }

            LoadMonthsForSelectedYear();

            cmbAno.SelectedIndexChanged += cmbAno_SelectedIndexChanged;
            cmbMes.SelectedIndexChanged += cmbMes_SelectedIndexChanged;
        }

        private void LoadMonthsForSelectedYear()
        {
            if (cmbAno.SelectedItem == null) return;

            string selectedYear = cmbAno.SelectedItem.ToString();
            var months = fechaRepository.ObtenerLosMesesPorAno(selectedYear);

            if (months != null && months.Any())
            {
                var monthNames = months
                    .Select(mes => new
                    {
                        Number = int.Parse(mes),
                        Name = tool.numberToMonth(int.Parse(mes))
                    })
                    .OrderBy(m => m.Number)
                    .Select(m => m.Name)
                    .ToList();

                cmbMes.DataSource = monthNames;

                if (selectedYear == DateTime.Now.Year.ToString())
                {
                    string currentMonthName = tool.numberToMonth(actualMonth);
                    int currentMonthIndex = monthNames.IndexOf(currentMonthName);

                    if (currentMonthIndex >= 0)
                    {
                        cmbMes.SelectedIndex = currentMonthIndex;
                    }
                    else
                    {
                        cmbMes.SelectedIndex = cmbMes.Items.Count - 1;
                    }
                }
                else
                {
                    cmbMes.SelectedIndex = cmbMes.Items.Count - 1;
                }
            }
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDgvATF();
        }

        private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMonthsForSelectedYear();
            CargarDgvATF();
        }

        private void CargarDgvReporteDia()
        {
            
        }

        private void CargarDgvATF()
        {
            dgvMostrarATF.Rows.Clear();

            string mesSeleccionado = cmbMes.SelectedItem?.ToString();
            string anoSeleccionado = cmbAno.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(mesSeleccionado) || string.IsNullOrEmpty(anoSeleccionado))
                return;

            var empleados = empleadosCache;
            var estadosAsistencia = estadosAsistenciaCache;
            var registros = registroDiarioRepository.ListarRegistrosDiarios(anoSeleccionado, int.Parse(tool.monthToNumber(mesSeleccionado)));

            foreach (var empleado in empleados)
            {
                int asistencias = 0;
                int tardanzas = 0;
                int faltas = 0;

                var registrosEmpleado = registros.Where(r =>
                    r.idEmpleado == empleado.idEmpleado &&
                    r.Fecha.mes == tool.monthToNumber(mesSeleccionado) &&
                    r.Fecha.ano == anoSeleccionado
                );

                foreach (var registro in registrosEmpleado)
                {
                    if (registro.horaEntrada.HasValue)
                    {
                        var estado = estadosAsistencia.Single(e => e.idEvento.Equals(registro.idEstadoAsistencia.Value)).nombreEvento;

                        if (estado.Equals("Asistencia"))
                        {
                            asistencias++;
                        }
                        else if (estado.Equals("Falta"))
                        {
                            faltas++;
                        }
                        else
                        {
                            tardanzas++;
                        }
                    }
                    else
                    {
                        faltas++;
                    }
                }

                dgvMostrarATF.Rows.Add(
                    $"{empleado.apellidoEmpleado}, {empleado.nombreEmpleado}",
                    asistencias,
                    tardanzas,
                    faltas
                );
            }
        }
    }
}

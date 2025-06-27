using InterfazAdministrador.Data;
using InterfazAdministrador.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InterfazAdministrador.Interfaces
{
    public partial class FrmTurnos : Form
    {
        private readonly TurnoRepository turnoRepository = new TurnoRepository();
        private readonly Tool tools = new Tool();
        private List<Turno> turnos;

        public FrmTurnos()
        {
            InitializeComponent();

            turnos = turnoRepository.ObtenerTurnos();
            llenarDGV(turnos);

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void llenarDGV(List<Turno> turnos)
        {
            dgvTurnos.Rows.Clear();

            foreach (var turno in turnos)
            {
                dgvTurnos.Rows.Add(turno.nombreTurno, tools.FormatearHora(turno.horaInicio), tools.FormatearHora(turno.horaFin));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar el campo para poder agregar un nuevo rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpInicio.Value.TimeOfDay == dtpFin.Value.TimeOfDay)
            {
                MessageBox.Show("La hora de inicio y fin no pueden ser iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpInicio.Value.TimeOfDay > dtpFin.Value.TimeOfDay)
            {
                MessageBox.Show("La hora de inicio no puede ser mayor que la hora de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpInicio.Value.TimeOfDay - dtpFin.Value.TimeOfDay < TimeSpan.FromHours(6))
            {
                MessageBox.Show("La duración del turno debe ser de al menos 6 horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existeTurno = turnos.Any(t =>
                t.nombreTurno.ToLower().Equals(txtNombre.Text.ToLower())
                || t.horaInicio.Equals(dtpInicio.Value.TimeOfDay)
                && t.horaFin.Equals(dtpFin.Value.TimeOfDay)
            );

            if (existeTurno)
            {
                MessageBox.Show("El turno ingresado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nuevoTurno = new Turno()
            {
                nombreTurno = txtNombre.Text,
                horaInicio = dtpInicio.Value.TimeOfDay,
                horaFin = dtpFin.Value.TimeOfDay
            };

            turnoRepository.AgregarTurno(nuevoTurno);
            MessageBox.Show("Turno agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            turnos = turnoRepository.ObtenerTurnos();
            llenarDGV(turnos);
            txtNombre.Text = string.Empty;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar el campo para poder eliminar un nuevo turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existeTurno = turnos.Any(t =>
                t.nombreTurno.ToLower().Equals(txtNombre.Text.ToLower())
                || t.horaInicio.Equals(dtpInicio.Value.TimeOfDay)
                && t.horaFin.Equals(dtpFin.Value.TimeOfDay)
            );
            if (!existeTurno)
            {
                MessageBox.Show("No existe el turno Ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personmasConTurno = turnoRepository.NumEmpleadosConTurno(txtNombre.Text);
            if (personmasConTurno > 0)
            {
                MessageBox.Show("No se puede eliminar el turno porque hay empleados asignados a él.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el turno: {txtNombre}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool eliminado = turnoRepository.EliminarTurno(txtNombre.Text);
                if (eliminado)
                {
                    MessageBox.Show("Empleado eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    turnos = turnoRepository.ObtenerTurnos();
                    llenarDGV(turnos);
                }
                else
                {
                    MessageBox.Show("Error al eliminar el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtNombre.Text = string.Empty;
                dtpInicio.Value = DateTime.Now;
                dtpFin.Value = DateTime.Now.AddHours(6);
                btnAgregar.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtpInicio.Value.TimeOfDay == dtpFin.Value.TimeOfDay)
            {
                MessageBox.Show("La hora de inicio y fin no pueden ser iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpInicio.Value.TimeOfDay > dtpFin.Value.TimeOfDay)
            {
                MessageBox.Show("La hora de inicio no puede ser mayor que la hora de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpInicio.Value.TimeOfDay - dtpFin.Value.TimeOfDay < TimeSpan.FromHours(6))
            {
                MessageBox.Show("La duración del turno debe ser de al menos 6 horas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existeTurno = turnos.Any(t =>
                t.nombreTurno.ToLower().Equals(txtNombre.Text.ToLower())
                || t.horaInicio.Equals(dtpInicio.Value.TimeOfDay)
                && t.horaFin.Equals(dtpFin.Value.TimeOfDay)
            );

            if (existeTurno)
            {
                MessageBox.Show("El turno ingresado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var turno = new Turno()
            {
                nombreTurno = txtNombre.Text,
                horaInicio = dtpInicio.Value.TimeOfDay,
                horaFin = dtpFin.Value.TimeOfDay
            };

            turnoRepository.ActualizarTurno(turno);
            MessageBox.Show("Rol modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Text = string.Empty;
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now.AddHours(6);
            turnos = turnoRepository.ObtenerTurnos();
            llenarDGV(turnos);
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
    }
}

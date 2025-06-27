using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class TurnoRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<Turno> ObtenerTurnos()
        {
            return db.Turno.ToList();
        }

        public void AgregarTurno(Turno nuevoTurno)
        {
            db.Turno.InsertOnSubmit(nuevoTurno);
            db.SubmitChanges();
        }

        internal int NumEmpleadosConTurno(string text)
        {
            return db.Empleado.Count(e => e.Turno.nombreTurno.Equals(text));
        }

        internal bool EliminarTurno(string text)
        {
            var turno = db.Turno.FirstOrDefault(e => e.nombreTurno.Equals(text));
            if (turno == null) return false;
            db.Turno.DeleteOnSubmit(turno);
            db.SubmitChanges();
            return true;
        }

        internal void ActualizarTurno(Turno turno)
        {
            var actualizarTurno = db.Turno.FirstOrDefault(e => e.nombreTurno.Equals(turno.nombreTurno));
            actualizarTurno.nombreTurno = turno.nombreTurno;
            actualizarTurno.horaInicio = turno.horaInicio;
            actualizarTurno.horaFin = turno.horaFin;
            db.SubmitChanges();
        }
    }
}

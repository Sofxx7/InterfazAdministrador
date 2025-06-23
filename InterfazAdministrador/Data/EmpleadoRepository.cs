using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class EmpleadoRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<Empleado> ListarEmpleados()
        {
            return db.Empleado.ToList();
        }

        public Empleado ObtenerEmpleadoPorId(string id)
        {
            return db.Empleado.FirstOrDefault(e => e.idEmpleado.Equals(id));
        }

        public Empleado BuscarEmpleadoPorNombre(string apellido, string nombre)
        {
            return db.Empleado.FirstOrDefault(e => e.apellidoEmpleado == apellido && e.nombreEmpleado == nombre);
        }

        public bool EliminarEmpleado(string id)
        {
            var empleado = db.Empleado.FirstOrDefault(e => e.idEmpleado.Equals(id));
            if (empleado == null) return false;
            db.Empleado.DeleteOnSubmit(empleado);
            db.SubmitChanges();
            return true;
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            var empleadoExistente = db.Empleado.FirstOrDefault(e => e.idEmpleado.Equals(empleado.idEmpleado));
            if (empleadoExistente != null)
            {
                empleadoExistente.nombreEmpleado = empleado.nombreEmpleado;
                empleadoExistente.apellidoEmpleado = empleado.apellidoEmpleado;
                empleadoExistente.idRol = empleado.idRol;
                empleadoExistente.idTurno = empleado.idTurno;
                db.SubmitChanges();
            }
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            db.Empleado.InsertOnSubmit(empleado);
            db.SubmitChanges();
        }
    }
}

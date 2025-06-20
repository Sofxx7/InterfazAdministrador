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

        public bool EliminarEmpleado(string id)
        {
            var empleado = db.Empleado.FirstOrDefault(e => e.idEmpleado.Equals(id));
            if (empleado == null) return false;
            db.Empleado.DeleteOnSubmit(empleado);
            db.SubmitChanges();
            return true;
        }
    }
}

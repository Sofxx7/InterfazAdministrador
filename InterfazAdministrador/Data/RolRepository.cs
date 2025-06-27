using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class RolRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public List<Rol> ObtenerRoles()
        {
            return db.Rol.ToList();
        }

        public void AgregarRol(Rol rol)
        {
            db.Rol.InsertOnSubmit(rol);
            db.SubmitChanges();
        }

        public bool EliminarRol(string nombreRol)
        {
            var rol = db.Rol.FirstOrDefault(e => e.nombreRol.Equals(nombreRol));
            if (rol == null) return false;
            db.Rol.DeleteOnSubmit(rol);
            db.SubmitChanges();
            return true;
        }

        public void ActualizarRol(Rol rol)
        {
            var actualizarRol = db.Rol.FirstOrDefault(e => e.nombreRol.Equals(rol.nombreRol));
            if (actualizarRol != null)
            {
                actualizarRol.nombreRol = rol.nombreRol;
                db.SubmitChanges();
            }
        }

        internal int NumEmpleadosConRol(string text)
        {
            var rol = db.Rol.FirstOrDefault(r => r.nombreRol.Equals(text, StringComparison.OrdinalIgnoreCase));
            return db.Empleado.Count(e => e.Rol.nombreRol.Equals(rol.nombreRol, StringComparison.OrdinalIgnoreCase));
        }
    }
}

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
    }
}

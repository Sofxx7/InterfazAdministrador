﻿using System.Collections.Generic;
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
    }
}

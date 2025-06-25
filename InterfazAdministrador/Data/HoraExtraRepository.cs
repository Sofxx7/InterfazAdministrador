using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazAdministrador.Data
{
    internal class HoraExtraRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public bool InsertarHoraExtra(HoraExtra horaExtra)
        {
            try
            { 
                db.HoraExtra.InsertOnSubmit(horaExtra);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int ObtenerHorasExtrasPorEmpleado(string idEmpleadoStr, int idFecha)
        {
            if (string.IsNullOrWhiteSpace(idEmpleadoStr))
                return 0;

            return db.HoraExtra
                     .Where(h => h.idEmpleado == idEmpleadoStr && h.idFecha.Equals(idFecha))
                     .Select(h => (int?)h.minutosHorasExtras)
                     .FirstOrDefault() ?? 0;
        }
    }
}

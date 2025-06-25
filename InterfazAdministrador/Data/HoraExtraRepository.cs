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

        public int ObtenerHorasExtrasPorEmpleado(string idEmpleadoStr)
        {
            if (!int.TryParse(idEmpleadoStr, out int idEmpleado))
                return 0;

            return db.HoraExtra
                   .Where(h => h.idEmpleado.Equals(idEmpleado))
                   .Sum(h => (int?)h.minutosHorasExtras) ?? 0;
        }


    }
}

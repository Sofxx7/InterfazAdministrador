using System.Collections.Generic;
using System.Linq;

namespace InterfazAdministrador.Data
{
    internal class CaraRepository
    {
        DataClassesTableDataContext db = new DataClassesTableDataContext();

        public bool tieneCaras(string idEmpleado)
        {
            return db.Cara.Any(c => c.idEmpleado.Equals(idEmpleado));
        }

        public bool EliminarCaraEmpleado(int idCara)
        {
            var cara = db.Cara.Single(c => c.idCara.Equals(idCara));
            if (cara == null) return false;

            db.Cara.DeleteOnSubmit(cara);
            db.SubmitChanges();
            return true;
        }

        public List<Cara> ListarCaras(string idEmpleado)
        {
            return db.Cara.Where(c => c.idEmpleado.Equals(idEmpleado)).ToList();
        }
    }
}

using InterfazAdministrador.Service;
using System.Linq;
using System.Threading.Tasks;

namespace InterfazAdministrador.Data
{
    internal class CredencialRepository
    {
        private PasswordService passwordService = new PasswordService();
        private DataClassesTableDataContext db = new DataClassesTableDataContext();

        public async Task<bool> VerificarCredencialesAsync(string idEmpleado, string contrasena)
        {
            var credencial = db.Credencial.SingleOrDefault(c => c.idEmpleado.Equals(idEmpleado));
            if (credencial == null) return false;

            return await passwordService.VerificarContrasena(contrasena, credencial.hash_contrasena);
        }
    }
}

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

        public async Task<bool> ActualizarContrasenaAsync(string idEmpleado, string nuevaContrasena)
        {
            var credencial = db.Credencial.SingleOrDefault(c => c.idEmpleado.Equals(idEmpleado));
            if (credencial == null) return false;

            string hash = await passwordService.HashContrasena(nuevaContrasena);
            credencial.hash_contrasena = hash;
            db.SubmitChanges();
            return true;
        }
    }
}

using InterfazAdministrador.Service;
using System.Linq;
using System.Threading.Tasks;

namespace InterfazAdministrador.Data
{
    internal class CredencialRepository
    {
        private PasswordService passwordService = new PasswordService();

        public async Task<bool> VerificarCredencialesAsync(string idEmpleado, string contrasena)
        {
            string hashContrasena = null;
            using (var db = new DataClassesSPDataContext())
            {
                hashContrasena = db.SP_Autenticar(idEmpleado).FirstOrDefault().hash_contrasena;
            }
            if (hashContrasena == null) return false;
            return await passwordService.VerificarContrasena(contrasena, hashContrasena);
        }

        public async Task<bool> ActualizarContrasenaAsync(string idEmpleado, string nuevaContrasena)
        {
            using (var db = new DataClassesTableDataContext())
            {
                var credencial = db.Credencial.FirstOrDefault(c => c.idEmpleado.Equals(idEmpleado));
                if (credencial == null) return false;

                string hash = await passwordService.HashContrasena(nuevaContrasena);
                credencial.hash_contrasena = hash;
                db.SubmitChanges();
                return true;
            }
        }
    }
}

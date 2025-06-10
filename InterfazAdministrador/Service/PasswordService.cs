using Konscious.Security.Cryptography;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InterfazAdministrador.Service
{
    internal class PasswordService
    {
        private const int Paralelismo = 4;          // Núcleos de CPU
        private const int MemorySize = 65536;       // 64 MB en KiB
        private const int Iteracione = 4;           // Iteraciones
        private const int SaltSize = 16;            // 128 bits
        private const int HashSize = 32;            // 256 bits

        public async Task<string> HashContrasena(string password)
        {
            byte[] sal = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(sal);
            }

            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = sal,
                DegreeOfParallelism = Paralelismo,
                MemorySize = MemorySize,
                Iterations = Iteracione
            };

            byte[] hash = await argon2.GetBytesAsync(HashSize);

            byte[] result = new byte[SaltSize + HashSize];
            Buffer.BlockCopy(sal, 0, result, 0, SaltSize);
            Buffer.BlockCopy(hash, 0, result, SaltSize, HashSize);

            return Convert.ToBase64String(result);
        }

        public async Task<bool> VerificarContrasena(string password, string hashedPassword)
        {
            byte[] hashedBytes = Convert.FromBase64String(hashedPassword);

            byte[] salt = new byte[SaltSize];
            byte[] storedHash = new byte[HashSize];
            Buffer.BlockCopy(hashedBytes, 0, salt, 0, SaltSize);
            Buffer.BlockCopy(hashedBytes, SaltSize, storedHash, 0, HashSize);

            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                DegreeOfParallelism = Paralelismo,
                MemorySize = MemorySize,
                Iterations = Iteracione
            };

            byte[] computedHash = await argon2.GetBytesAsync(HashSize);

            return CompararHash(storedHash, computedHash);
        }

        private bool CompararHash(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }
            return result == 0;
        }
    }
}
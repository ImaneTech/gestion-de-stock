using System.Security.Cryptography;
using System.Text;

namespace Gestion_de_stock
{
    /// Hachage des mots de passe avec PBKDF2 (SHA-256, sel aléatoire).
    public static class PasswordHasher
    {
        public const int SaltSize = 16;
        public const int HashSize = 32;
        public const int Iterations = 100_000;

        public static (byte[] Hash, byte[] Salt) HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            return (Derive(password, salt), salt);
        }

        public static bool Verify(string password, byte[] expectedHash, byte[] salt)
        {
            byte[] actualHash = Derive(password, salt);
            // Comparaison en temps constant pour ne rien révéler via le temps de réponse
            return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
        }

        private static byte[] Derive(string password, byte[] salt)
        {
            return Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, Iterations, HashAlgorithmName.SHA256, HashSize);
        }
    }
}

namespace Gestion_de_stock
{
    /// Règles de mot de passe appliquées à l'inscription.
    public static class PasswordPolicy
    {
        public const int MinLength = 8;

        public const string Description = "Le mot de passe doit contenir au moins 8 caractères, dont des lettres et des chiffres.";

        public static bool IsValid(string password)
        {
            return password.Length >= MinLength
                && password.Any(char.IsLetter)
                && password.Any(char.IsDigit);
        }
    }
}

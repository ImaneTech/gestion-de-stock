namespace Gestion_de_stock
{
    /// Utilisateur actuellement connecté. Vidé à la déconnexion.
    public static class Session
    {
        public const string RoleAdmin = "admin";
        public const string RoleUser = "user";

        public static int? UserId { get; private set; }
        public static string? Username { get; private set; }
        public static string? Role { get; private set; }

        public static bool IsAuthenticated => UserId.HasValue;
        public static bool IsAdmin => IsAuthenticated && Role == RoleAdmin;

        public static void Start(int userId, string username, string role)
        {
            UserId = userId;
            Username = username;
            Role = role;
        }

        public static void Clear()
        {
            UserId = null;
            Username = null;
            Role = null;
        }

        /// Affiche un message et renvoie false si l'utilisateur connecté n'est pas administrateur.
        public static bool EnsureAdmin()
        {
            if (IsAdmin)
                return true;

            MessageBox.Show("Seul un administrateur peut effectuer une suppression.", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }
}

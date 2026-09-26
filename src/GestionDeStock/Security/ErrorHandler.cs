namespace Gestion_de_stock
{
    /// Enregistre le détail des erreurs dans un fichier local et n'affiche qu'un message générique à l'utilisateur.
    public static class ErrorHandler
    {
        private static readonly object fileLock = new object();

        public static string LogFilePath { get; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "GestionStock", "logs", "app.log");

        public static void Log(Exception ex, string context)
        {
            try
            {
                lock (fileLock)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(LogFilePath)!);
                    File.AppendAllText(LogFilePath, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [ERROR] {context}{Environment.NewLine}{ex}{Environment.NewLine}{Environment.NewLine}");
                }
            }
            catch
            {
                // La journalisation ne doit jamais faire planter l'application
            }
        }

        public static void Show(Exception ex, string userMessage)
        {
            Log(ex, userMessage);
            MessageBox.Show(userMessage + Environment.NewLine + "Si le problème persiste, contactez l'administrateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

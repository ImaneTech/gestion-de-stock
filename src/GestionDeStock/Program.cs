namespace Gestion_de_stock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Toute exception non gérée est journalisée ; l'utilisateur ne voit qu'un message générique
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) => ErrorHandler.Show(e.Exception, "Une erreur inattendue s'est produite.");
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                    ErrorHandler.Log(ex, "Exception non gérée");
            };

            Application.Run(new LoginForm());
        }
    }
}
using System.Configuration;

namespace Gestion_de_stock
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["GlobalConnection"].ConnectionString;
        }
    }
}
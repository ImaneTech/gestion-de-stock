using Microsoft.Data.SqlClient;
using System.Data;

namespace Gestion_de_stock
{
    /// Accès simple à la base : ouvre une connexion, exécute une requête paramétrée et la referme.
    /// Les opérations qui doivent partager une transaction gèrent elles-mêmes leur connexion.
    public static class Db
    {
        public static SqlConnection OpenConnection()
        {
            SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString());
            connect.Open();
            return connect;
        }

        /// Exécute une requête SELECT et renvoie le résultat sous forme de DataTable.
        public static DataTable Query(string sql, params (string Name, object Value)[] parameters)
        {
            using (SqlConnection connect = OpenConnection())
            using (SqlCommand cmd = CreateCommand(sql, connect, parameters))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        /// Exécute une requête et renvoie la première colonne de la première ligne.
        public static object? Scalar(string sql, params (string Name, object Value)[] parameters)
        {
            using (SqlConnection connect = OpenConnection())
            using (SqlCommand cmd = CreateCommand(sql, connect, parameters))
            {
                return cmd.ExecuteScalar();
            }
        }

        /// Exécute un INSERT / UPDATE / DELETE et renvoie le nombre de lignes affectées.
        public static int Execute(string sql, params (string Name, object Value)[] parameters)
        {
            using (SqlConnection connect = OpenConnection())
            using (SqlCommand cmd = CreateCommand(sql, connect, parameters))
            {
                return cmd.ExecuteNonQuery();
            }
        }

        private static SqlCommand CreateCommand(string sql, SqlConnection connect, (string Name, object Value)[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, connect);
            foreach (var (name, value) in parameters)
                cmd.Parameters.AddWithValue(name, value);
            return cmd;
        }
    }
}

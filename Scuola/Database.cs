using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Scuola
{
    public static class GestioneMySql
    {
        public static string StringaConnessione =
            "Data Source=localhost;Database=alunni;userid=root;password=\"\";";
        public static MySqlConnection Connessione = new MySqlConnection(StringaConnessione);

        public static bool ApriConnessione()
        {
            try
            {
                if (Connessione.State != ConnectionState.Open)
                {
                    Connessione.ConnectionString = GestioneMySql.StringaConnessione;
                    Connessione.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ChiudiConnessione()
        {
            try
            {
                if (Connessione.State != System.Data.ConnectionState.Closed)
                {
                    Connessione.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

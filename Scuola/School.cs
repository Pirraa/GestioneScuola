using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scuola
{
    public class School
    {
        static private School instance = null;
        static public School Instance
        {
            get
            {
                if (instance == null) instance = new School();
                return instance;
            }
        }

        public void Metodo()
        {
            Console.WriteLine("Metodo richiamato");
        }

        private School()
        {
            Console.WriteLine("Oggetto creato");
        }

        public void addUser(int id, string nome, string cognome, string email, string telefono)
        {

        }

        public void removeUser(int id)
        {

        }

        public void provaDb()
        {
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT nome, cognome, data_nascita, cellulare FROM alunni.studenti ");
                //sb.AppendLine(" FROM test.persone ");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string nome = dr.GetString("nome");
                            string cognome = dr.GetString("cognome");
                            DateTime dataNascita = dr.GetDateTime("data_nascita");
                            string cellulare = dr.GetString("cellulare");
                            MessageBox.Show($"{nome}, {cognome}, {dataNascita.ToString()}, {cellulare}");
                        }
                    }
                }

                // Chiusura connessione
                if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");
            }
            catch (Exception ex)
            {
                GestioneMySql.ChiudiConnessione();
                Console.WriteLine("Errore: " + ex.Message);
            }
        }

    }
}

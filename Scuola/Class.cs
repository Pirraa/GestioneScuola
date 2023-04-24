using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scuola
{
    public class Classe
    {
        public int Anno { get; set; }
        public int Id { get; set; }
        public char Sezione { get; set; }

        public Classe(int id, int anno, char sezione)
        {
            this.Id = id;
            this.Anno = anno;
            this.Sezione = sezione;
        }

        public Classe()
        {

        }

        public List<Classe> leggi()
        {
            //ottiene l'elenco delle classi
            List<Classe> classi = new List<Classe>();
            //visualizza lista delle materie
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT id, anno, sezione FROM classe");

                MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione);

                //return materie;
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        classi.Add(new Classe(dr.GetInt32("id"), dr.GetInt32("anno"), dr.GetChar("sezione")));
                    }
                }
                return classi;

                if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");

            }
            catch (Exception ex)
            {
                GestioneMySql.ChiudiConnessione();
                Console.WriteLine("Errore: " + ex.Message);
            }
            return null;
        }

        public void aggiungi(int anno, char sezione)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO classe (anno, sezione) VALUES (@anno, @sezione)");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@anno", anno));
                    cmd.Parameters.Add(new MySqlParameter("@sezione", sezione));

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Records Inserted Successfully");
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Error Generated. Details: " + e.ToString());
                    }

                }

                if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        public void rimuovi(int id_classe)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(" DELETE FROM classe WHERE classe.id=@id;");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id_classe));
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Records deleted Successfully");
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Error Generated. Details: " + e.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }
    }
}

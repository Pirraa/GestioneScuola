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
    public class Lezione
    {
        int id;
        DateTime ora_inizio;
        DateTime ora_fine;
        int id_materia;
        int id_docente;
        string descrizione;
        string materia;
        string docente;

        public DateTime Ora_inizio { get => ora_inizio; set => ora_inizio = value; }
        public DateTime Ora_fine { get => ora_fine; set => ora_fine = value; }
        public int Id_materia { get => id_materia; set => id_materia = value; }
        public int Id_docente { get => id_docente; set => id_docente = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public string Materia { get => materia; set => materia = value; }
        public string Docente { get => docente; set => docente = value; }
        public int Id { get => id; set => id = value; }

        public Lezione(int id,DateTime ora_inizio, DateTime ora_fine, string materia, string docente, string descrizione)
        {
            Id = id;
            Ora_inizio = ora_inizio;
            Ora_fine = ora_fine;
            Materia= materia;
            Docente = docente;
            Descrizione = descrizione;
        }

        public Lezione()
        {

        }

        public List <Lezione> leggi()
        {
            //elenco lezioni non filtrate
            //restituisce le assenze di uno studente
            List<Lezione> lezioni = new List<Lezione>();
            //visualizza lista delle materie
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select l.id, l.data_inizio , l.data_fine , m.descrizione as materia, l.descrizione, concat(d.nome,d.cognome) as docente\r\nfrom lezione l\r\ninner join docente d on l.id_docente = d.id_docente \r\ninner join materia m on m.id_materia = l.materia");

                MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lezioni.Add(new Lezione(dr.GetInt32("id"),dr.GetDateTime("data_inizio"), dr.GetDateTime("data_fine"), dr.GetString("materia"), dr.GetString("docente"), dr.GetString("descrizione")));
                    }
                }
                return lezioni;


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

        public void aggiungi(int id_docente, DateTime data_inizio, DateTime data_fine, int id_materia, string descrizione)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO lezione (id_docente, data_inizio, data_fine, materia, descrizione) VALUES (@id_docente, @data_inizio, @data_fine, @id_materia, @descrizione)");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id_docente", id_docente));
                    cmd.Parameters.Add(new MySqlParameter("@data_inizio", data_inizio));
                    cmd.Parameters.Add(new MySqlParameter("@data_fine", data_fine));
                    cmd.Parameters.Add(new MySqlParameter("@id_materia", id_materia));
                    cmd.Parameters.Add(new MySqlParameter("@descrizione", descrizione));

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

                // Chiusura connessione
                if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");
            }
            catch (Exception ex)
            {
                /*GestioneMySql.ChiudiConnessione();*/
                MessageBox.Show("Errore: " + ex.Message);
            }
        }
    }
}

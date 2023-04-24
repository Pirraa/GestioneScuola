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
    public class Assenza
    {
        int id;
        int id_studente;
        DateTime data_inizio;
        DateTime data_fine;
        byte giustificato;
        string motivazione;
        string studente;

        public int Id_studente { get => id_studente; set => id_studente = value; }
        public DateTime Data_inizio { get => data_inizio; set => data_inizio = value; }
        public DateTime Data_fine { get => data_fine; set => data_fine = value; }
        public byte Giustificato { get => giustificato; set => giustificato = value; }
        public string Motivazione { get => motivazione; set => motivazione = value; }
        public int Id { get => id; set => id = value; }
        public string Studente { get => studente; set => studente = value; }

        public Assenza(int id, DateTime data_inizio, DateTime data_fine, byte giustificato, string motivazione, string studente)
        {
            Id = id;
            Data_inizio = data_inizio;
            Data_fine = data_fine;
            Giustificato = giustificato;
            Motivazione = motivazione;
            Studente = studente;
        }

        public Assenza()
        {

        }

        public List<Assenza> leggi()
        {
            //elenco lezioni non filtrate
            //restituisce le assenze di uno studente
            List<Assenza> assenze = new List<Assenza>();
            //visualizza lista delle materie
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select a.id, a.data_inizio , a.data_fine , a.motivazione , a.giustificato, concat (s.cognome, s.nome) as studente");
                sb.AppendLine("from assenza a ");
                sb.AppendLine("inner join studente s on s.id_studente = a.id_studente");
 
                MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        assenze.Add(new Assenza(dr.GetInt32("id"), dr.GetDateTime("data_inizio"), dr.GetDateTime("data_fine"), dr.GetByte("giustificato"),dr.GetString("motivazione"),dr.GetString("studente")));
                    }
                }
                return assenze;


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

        public void aggiungi(int id_studente, DateTime data_inizio, DateTime data_fine, string motivazione)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO assenza (id_studente, data_inizio, data_fine, motivazione) VALUES (@id_studente, @data_inizio, @data_fine, @motivazione)");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id_studente", id_studente));
                    cmd.Parameters.Add(new MySqlParameter("@data_inizio", data_inizio));
                    cmd.Parameters.Add(new MySqlParameter("@data_fine", data_fine));
                    cmd.Parameters.Add(new MySqlParameter("@motivazione", motivazione));

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
    }
}

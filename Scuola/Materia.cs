using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Scuola
{
    public class Materia
    {
        int id;
        string descrizione;
        string docente;

        public string Descrizione { get => descrizione; set => descrizione = value; }
        public int Id { get => id; set => id = value; }
        public string Docente { get => docente; set => docente = value; }

        public Materia()
        {

        }

        public Materia(int id, string descrizione, string docente)
        {
            this.Id = id;
            this.descrizione = descrizione;
            this.docente = docente;
        }

        public List<Materia> leggi()
        {
            List < Materia > materie = new List<Materia>();

            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT distinct materia.id_materia, materia.descrizione as materia, \r\nconcat(docente.nome,' ',docente.cognome) as docente FROM materia \r\nleft join docente_materia on docente_materia.id_materia=materia.id_materia\r\nleft join docente on docente.id_docente=docente_materia.id_docente\r\n ");

                MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        materie.Add(new Materia(dr.GetInt32("id_materia"), dr.GetString("materia"), dr.GetString("docente")));
                    }
                }
                return materie;
               

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

        public void aggiungi(string descrizione, int id_docente) //da richiamare con associaDocenteMateria
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO materia (descrizione) VALUES (@descrizione)");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@descrizione", descrizione));

                    try
                    {
                        cmd.ExecuteNonQuery();
                        associaDocenteMateria((int)cmd.LastInsertedId, id_docente);
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

        public void associaDocenteMateria(int id_materia, int id_docente)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO docente_materia (id_materia, id_docente) VALUES (@id_materia, @id_docente)");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id_materia", id_materia));
                    cmd.Parameters.Add(new MySqlParameter("@id_docente", id_docente));

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

        public void rimuovi(int id_materia)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(" DELETE FROM materia WHERE materia.id_materia=@id;");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id_materia));
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

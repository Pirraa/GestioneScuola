using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Scuola
{
    public class Voto
    {
        int id;
        int id_docente;
        int id_studente;
        int voto;
        int id_materia;
        string studente;
        string materia;
        string docente;

        public int Id_docente { get => id_docente; set => id_docente = value; }
        public int Id_studente { get => id_studente; set => id_studente = value; }
        public int Votoo { get => voto; set => voto = value; }
        public int Id_materia { get => id_materia; set => id_materia = value; }
        public int Id { get => id; set => id = value; }
        public string Studente { get => studente; set => studente = value; }
        public string Materia { get => materia; set => materia = value; }
        public string Docente { get => docente; set => docente = value; }

        public Voto(int id_docente, int id_studente, int voto, int id_materia)
        {
            Id_docente = id_docente;
            Id_studente = id_studente;
            Votoo = voto;
            Id_materia = id_materia;
        }

        public Voto()
        {

        }

        public Voto(int id, string studente, string materia, string docente, int voto) 
        {
            this.Id = id;
            this.Studente = studente;
            this.Materia = materia;
            this.Docente = docente;
            this.voto = voto;
        }

        public List<Voto> leggi()
        {
            List<Voto> voti = new List<Voto>();
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select v.id, CONCAT(s.nome, s.cognome) as studente, m.descrizione as materia, CONCAT(d.nome, d.cognome) as docente, v.voto ");
                sb.AppendLine(" from voto v inner join studente s on s.id_studente = v.id_studente");
                sb.AppendLine(" inner join docente d on d.id_docente = v.id_docente");
                sb.AppendLine(" inner join materia m on m.id_materia = v.id_materia ");

                MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        voti.Add(new Voto(dr.GetInt32("id"), dr.GetString("studente"), dr.GetString("materia"), dr.GetString("docente"), dr.GetInt32("voto")));
                    }
                }
                return voti;


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

        public void aggiungi(int id_materia, int id_docente, int id_studente, int voto)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO voto (id_materia, id_docente, id_studente, voto) VALUES (@materia, @docente, @studente, @voto)");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@materia", id_materia));
                    cmd.Parameters.Add(new MySqlParameter("@docente", id_docente));
                    cmd.Parameters.Add(new MySqlParameter("@studente", id_studente));
                    cmd.Parameters.Add(new MySqlParameter("@voto", voto));

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

        public void rimuovi(int id_voto)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(" DELETE FROM voto WHERE voto.id=@id;");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id_voto));
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

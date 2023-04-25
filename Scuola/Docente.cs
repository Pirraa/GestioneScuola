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
    public class Docente
    {
        List<Materia> materie = new List<Materia>();
        List<Lezione> lezioni = new List<Lezione>();

        int id;
        string nome;
        string cognome;
        string email;

        public Docente(int id, string nome, string cognome, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cognome = cognome;
            this.Email = email;
        }

        public Docente()
        {

        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }

        public List<Docente> leggi()
        {
            List<Docente> docenti = new List<Docente>();
            //restituisce la lista di Docenti e la visualizza in una tabella
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT d.id_docente, d.nome, d.cognome, d.email FROM docente d");
                //sb.AppendLine(" FROM test.persone ");

                MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(dr.GetString("nome"));
                        docenti.Add(new Docente(dr.GetInt32("id_docente"), dr.GetString("nome"), dr.GetString("cognome"), dr.GetString("email")));
                    }
                }
                return docenti;

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

        public void aggiungi(string nome, string cognome, string email)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("INSERT INTO docente (nome, cognome, email) values(@nome, @cognome, @email)");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@nome", nome));
                    cmd.Parameters.Add(new MySqlParameter("@cognome", cognome));
                    cmd.Parameters.Add(new MySqlParameter("@email", email));

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

        public void rimuovi(int id)
        {
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(" DELETE FROM docente WHERE docente.id_docente=@id;");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
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

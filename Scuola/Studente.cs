using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Scuola
{
    public class Studente 
    {
        List<Voto> voti = new List<Voto>();
        List<Assenza> assenze = new List<Assenza>();

        int id_classe;
        int id;
        string classe;
        string nome;
        string cognome;
        string email;
        
        public Studente(int id, string nome, string cognome, string email, int id_classe=0, string classe="" )
        {
            this.Id_classe=id_classe;
            this.Id=id;
            this.Classe=classe;
            this.Nome=nome;
            this.Cognome=cognome;
            this.Email=email;
        }

        public Studente()
        {

        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Email { get => email; set => email = value; }
        public string Classe { get => classe; set => classe = value; }
        public int Id { get => id; set => id = value; }
        public int Id_classe { get => id_classe; set => id_classe = value; }

        public List<Studente> leggi()
        {
            List<Studente> studenti = new List<Studente>();
            //restituisce la lista di studenti e la visualizza in una tabella
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" SELECT s.id_studente, s.nome, s.cognome, s.email, c.id as id_classe, CONCAT(c.anno , ' ' , c.sezione) as classe FROM studente s LEFT JOIN classe c on c.id=s.id_classe ");
                //sb.AppendLine(" FROM test.persone ");

                MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(dr.GetString("nome"));
                        studenti.Add(new Studente(dr.GetInt32("id_studente"), dr.GetString("nome"), dr.GetString("cognome"), dr.GetString("email"), dr.GetInt32("id_classe"), dr.GetString("classe")));
                    }
                }
                return studenti;

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

        public void aggiungi(string nome, string cognome, string email, int id_classe)
        {
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" INSERT INTO studente (nome, cognome, email) values(@nome, @cognome, @email)");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@nome", nome));
                    cmd.Parameters.Add(new MySqlParameter("@cognome", cognome));
                    cmd.Parameters.Add(new MySqlParameter("@email", email));

                    try
                    {
                        cmd.ExecuteNonQuery();
                        assegnaClasseStudente((int)cmd.LastInsertedId, id_classe);
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

        public void assegnaClasseStudente(int id_studente, int id_classe)
        {
            //metodo da richiamare dentro il metodo add studente 
            try
            {
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("UPDATE studente set id_classe=@id_classe WHERE studente.id_studente=@id_studente");

                using (MySqlCommand cmd = new MySqlCommand(sb.ToString(), GestioneMySql.Connessione))
                {
                    cmd.Parameters.Add(new MySqlParameter("@id_classe", id_classe));
                    cmd.Parameters.Add(new MySqlParameter("@id_studente", id_studente));

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
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" DELETE FROM studente WHERE studente.id_studente=@id;");

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

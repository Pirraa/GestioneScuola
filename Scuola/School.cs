using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        
        public void addStudente( string nome, string cognome, string email)
        {
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" INSERT INTO studente (nome, cognome, email) values(@nome, @cognome, @email)"  );

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

                // Chiusura connessione
                /*if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");*/
            }
            catch (Exception ex)
            {
                /*GestioneMySql.ChiudiConnessione();*/
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        public void removeStudent(int id)
        {
            try
            {
                // Apertura connessione
                if (!GestioneMySql.ApriConnessione())
                    throw new Exception("Errore nell'apertura della connessione.");

                // Query da eseguire
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(" DELETE FROM studente WHERE studente.id=@id;"  );

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
                /*if (!GestioneMySql.ChiudiConnessione())
                    throw new Exception("Errore nella chiusura della connessione.");*/
            }
            catch (Exception ex)
            {
                /*GestioneMySql.ChiudiConnessione();*/
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        public void readStudent()
        {
            //restituisce la lista di studenti e la visualizza in una tabella
        }

        public void aggiungiDocente(string nome, string cognome, string email)
        {

        }

        public void rimuoviDocente(int id)
        {

        }

        public void leggiDocenti()
        {
            //restituisce la lista di docente e la visualizza in una tabella
        }

        public void aggiungiVoto(int id_materia, int id_docente, int id_studente, int voto)
        {
            //aggiunge un voto alla tabella voti
        }

        public void visualizzaVotiStudente(int id_studente) //eventuale aggiunta di altri due metodi per filtrare per materia e docente
        {

        }

        public void rimuoviVoto(int id_voto)
        {

        }

        public void aggiungiMateria(string descrizione, int id_docente)
        {
            //inserisce la materia nella tabella e assegna un docente
        }

        public void rimuoviMateria(int id_materia)
        {

        }

        public void getMaterie()
        {
            //visualizza lista delle materie
        }
        
        public void aggiungiClasse(int anno, char sezione)
        {

        }

        public void assegnaClasseStudente(int id_studente, int id_classe)
        {
            //metodo da richiamare dentro il metodo add studente 
        }

        public void eliminaClasse(int id_classe)
        {

        }

        public void getClassi()
        {
            //ottiene l'elenco delle classi
        }

        public void aggiungiAssenza(int id_studente, DateTime data_inizio, DatetTime data_fine, string motivazione)
        {

        }

        public void giustificaAssenza(int id_assenza)
        {

        }

        public void getAssenzeStudent(int id_studente)
        {
            //restituisce le assenze di uno studente
        }

        public void aggiungiLezione(int id_docente, DateTime data_inizio, DatetTime data_fine, int id_materia, string descrizione )
        {
            
        }

        public void visualizzaLezioni()
        {
            //elenco lezioni non filtrate
        }

        public void provaGet()
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

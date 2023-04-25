using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Scuola
{
    public class School
    {
        static private School instance = null;
        private static readonly object locked = new object ();  
        static public School Instance
        {
            get
            {
                lock(locked)
                {
                    if (instance == null) instance = new School();
                    return instance;
                }
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

        public List<Studente> leggiStudenti()
        {
            List<Studente> students = new List<Studente>();
            Studente studente = new Studente();
            students = studente.leggi();
            return students;
        }

        public List<Classe> leggiClassi()
        {
            List<Classe> classi = new List<Classe>();
            Classe classe = new Classe();
            classi = classe.leggi();
            return classi;
        }

        public List<Materia> leggiMaterie()
        {
            List<Materia> materie = new List<Materia>();
            Materia materia = new Materia();
            materie = materia.leggi();
            return materie;
        }

        public List<Docente> leggiDocenti()
        {
            List<Docente> docenti = new List<Docente>();
            Docente docente = new Docente();
            docenti = docente.leggi();
            return docenti;
        }


        public List<Voto> leggiVoti()
        {
            List<Voto> voti = new List<Voto>();
            Voto voto = new Voto();
            voti = voto.leggi();
            return voti;
        }

        public List<Assenza> leggiAssenze()
        {
            List<Assenza> assenze = new List<Assenza>();
            Assenza assenza = new Assenza();
            assenze = assenza.leggi();
            return assenze;
        }

        public List<Lezione> leggiLezioni()
        {
            List<Lezione> lezioni = new List<Lezione>();
            Lezione lezione = new Lezione();
            lezioni = lezione.leggi();
            return lezioni;
        }

        public void aggiungiStudente(string nome, string cognome, string email, int id_classe)
        {
            Studente studente = new Studente();
            studente.aggiungi(nome, cognome,email,id_classe);
        }

        public void aggiungiDocente(string nome, string cognome, string email)
        {
            Docente docente = new Docente();
            docente.aggiungi(nome, cognome, email);
        }

        public void aggiungiVoto(int id_materia, int id_docente, int id_studente, int voto)
        {
            Voto votoo = new Voto();
            votoo.aggiungi(id_materia, id_docente, id_studente, voto);
        }

        public void aggiungiMateria (string descrizione, int id_docente)
        {
            Materia materia = new Materia();
            materia.aggiungi(descrizione, id_docente);
        }

        public void aggiungiClasse(int anno, char sezione)
        {
            Classe classe = new Classe();
            classe.aggiungi(anno, sezione);
        }

        public void aggiungiLezione(int id_docente, DateTime data_inizio, DateTime data_fine, int id_materia, string descrizione)
        {
            Lezione lezione = new Lezione();
            lezione.aggiungi( id_docente, data_inizio, data_fine, id_materia, descrizione);
        }

        public void aggiungiAssenza(int id_studente, DateTime data_inizio, DateTime data_fine, string motivazione, bool giustificato)
        {
            Assenza assenza = new Assenza();
            assenza.aggiungi(id_studente, data_inizio, data_fine, motivazione, giustificato);
        }

        public void rimuoviStudente(int id)
        {
            Studente studente = new Studente();
            studente.rimuovi(id);
        }

        public void rimuoviDocente(int id)
        {
            Docente docente = new Docente();
            docente.rimuovi(id);
        }

        //questi ultimi metodi non sono collegati al frontend, bisogna sostituire il datasource con un ciclo for e aggiungere il metodo keydown della datagridwiev con il tasto canc
        public void rimuoviVoto(int id)
        {
            Voto votoo = new Voto();
            votoo.rimuovi(id);
        }

        public void rimuoviMateria(int id)
        {
            Materia materia = new Materia();
            materia.rimuovi(id);
        }

        public void rimuoviClasse(int id)
        {
            Classe classe = new Classe();
            classe.rimuovi(id);
        }

        public void giustificaAssenza(int id_assenza)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scuola
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            List<Studente> studenti = new List<Studente>();
            studenti=School.Instance.leggiStudenti();

            DataGridViewColumn id = new DataGridViewTextBoxColumn();
            id.HeaderText = "Id";
            id.Name = "id";
            dataGridViewStudenti.Columns.Add(id);

            DataGridViewColumn nome = new DataGridViewTextBoxColumn();
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            dataGridViewStudenti.Columns.Add(nome);

            DataGridViewColumn cognome = new DataGridViewTextBoxColumn();
            cognome.HeaderText = "Cognome";
            cognome.Name = "cognome";
            dataGridViewStudenti.Columns.Add(cognome);

            DataGridViewColumn email = new DataGridViewTextBoxColumn();
            email.HeaderText = "Email";
            email.Name = "email";
            dataGridViewStudenti.Columns.Add(email);

            DataGridViewColumn classe = new DataGridViewTextBoxColumn();
            classe.HeaderText = "Classe";
            classe.Name = "clase";
            dataGridViewStudenti.Columns.Add(classe);

            for (int i=0; i<studenti.Count; i++)
            {
                dataGridViewStudenti.Rows.Add(studenti[i].Id,studenti[i].Nome,studenti[i].Cognome,studenti[i].Email,studenti[i].Classe);
            }

            /*dataGridViewStudenti.DataSource = null;
            dataGridViewStudenti.DataSource = School.Instance.leggiStudenti();*/

            dataGridViewDocenti.DataSource = null;
            dataGridViewDocenti.DataSource = School.Instance.leggiDocenti();
        }

        private void studenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Studente> studenti = new List<Studente>();
            studenti = School.Instance.leggiStudenti();
            formAggiungiStudente formAggiungiStudente = new formAggiungiStudente();
            formAggiungiStudente.ShowDialog();
            for (int i = 0; i < studenti.Count; i++)
            {
                dataGridViewStudenti.Rows.Add(studenti[i].Id, studenti[i].Nome, studenti[i].Cognome, studenti[i].Email, studenti[i].Classe);
            }

            
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggiungiDocente AggiungiDocente = new AggiungiDocente();
            AggiungiDocente.ShowDialog();

            dataGridViewDocenti.DataSource = null;
            dataGridViewDocenti.DataSource = School.Instance.leggiDocenti();
        }

        private void votiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AggiungiVoto AggiungiVoto = new AggiungiVoto();
            AggiungiVoto.ShowDialog();
        }

        private void assenzeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AggiungiAssenze AggiungiAssenze = new AggiungiAssenze();
            AggiungiAssenze.ShowDialog();
        }

        private void lezioniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AggiungiLezione AggiungiLezione = new AggiungiLezione();
            AggiungiLezione.ShowDialog();
        }

        private void classiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggiungiClassi AggiungiClassi = new AggiungiClassi();
            AggiungiClassi.ShowDialog();
        }

        private void materieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AggiungiMateria AggiungiMateria = new AggiungiMateria();
            AggiungiMateria.ShowDialog();
        }

        private void votiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizzaVoti VisualizzaVoti = new VisualizzaVoti();
            VisualizzaVoti.ShowDialog();
        }

        private void assenzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizzaAssenze VisualizzaAssenze = new VisualizzaAssenze();
            VisualizzaAssenze.ShowDialog();
        }

        private void lezioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualizzaLezioni VisualizzaLezioni = new VisualizzaLezioni();
            VisualizzaLezioni.ShowDialog();
        }

        private void classiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizzaClassi VisualizzaClassi = new VisualizzaClassi();
            VisualizzaClassi.ShowDialog();
        }

        private void materieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisualizzaMaterie VisualizzaMaterie = new VisualizzaMaterie();
            VisualizzaMaterie.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewStudenti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewRow selectedRow = dataGridViewStudenti.SelectedRows[0];
                dataGridViewStudenti.Rows.RemoveAt(dataGridViewStudenti.SelectedRows[0].Index);
                DataGridViewCell selectedCell = selectedRow.Cells[0];
                int indice = Convert.ToInt32(selectedCell.Value);
                School.Instance.rimuoviStudente((int)indice);
            }
        }

        private void dataGridViewStudenti_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}

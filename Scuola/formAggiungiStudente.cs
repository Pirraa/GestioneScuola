using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Gestiamo aggiunta rimozione aggiornamento e visualizzazione docenti e studenti
 * Gestione voti, aggiunti dal docente a uno studente, lo studente pu� visualizzarli (modifica e elimina opzionali)
 * Gestione materie, il docente sceglie quali insegnare, poi le visualizza (eventuale modifica e rimozione perch� posono cambiare)
 * Gestione assenze, il docente inserisce ch uno studente � assente 
 * Gestione lezioni, un docente crea una lezione, come quando firma il registro, poi pu� solo visualizzarle
 * Gestione classi e appello complicata, evieterei anche se � essenziale
 * eventuali comunicazioni segreteria, agenda con verifiche compiti e didattica aggiuntivi se riusciamo a fare a parte prima ma sono pi� complessi. 
 */

namespace Scuola
{
    public partial class formAggiungiStudente : Form
    {
        public formAggiungiStudente()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            int id_classe=Convert.ToInt32(comboBoxClasse.GetItemText(comboBoxClasse.SelectedValue));
            School.Instance.aggiungiStudente(txtNome.Text, txtCognome.Text,txtEmail.Text,id_classe);
        }

        private void formAggiungiStudente_Load(object sender, EventArgs e)
        {
            /* ;
            classi = School.Instance.leggiClassi();
            comboBoxClasse.DataSource = classi;

            for (int i = 0; i < classi.Count; i++)
            {
                comboBoxClasse.Items.Add(classi[i].Anno);
            }*/
            List<Classe> classi = new List<Classe>();
            classi = School.Instance.leggiClassi();
            comboBoxClasse.DisplayMember = "annosezione";
            comboBoxClasse.ValueMember = "id";
            comboBoxClasse.DataSource=classi.Select(p => new { annosezione = $"{p.Anno} {p.Sezione}", p.Id }).ToList();
        }

        private void studenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

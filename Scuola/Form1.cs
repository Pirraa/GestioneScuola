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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            School.Instance.provaDb();
        }
    }
}

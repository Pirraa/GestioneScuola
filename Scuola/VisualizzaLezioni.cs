using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scuola
{
    public partial class VisualizzaLezioni : Form
    {
        public VisualizzaLezioni()
        {
            InitializeComponent();
        }

        private void VisualizzaLezioni_Load(object sender, EventArgs e)
        {
            /*dataGridViewLezioni.DataSource = null;
            dataGridViewLezioni.DataSource = School.Instance.leggiLezioni();*/

            List<Lezione> lezioni = new List<Lezione>();
            lezioni = School.Instance.leggiLezioni();

            for (int i = 0; i < lezioni.Count; i++)
            {
                dataGridViewLezioni.Rows.Add(lezioni[i].Id, lezioni[i].Ora_inizio, lezioni[i].Ora_fine, lezioni[i].Docente, lezioni[i].Materia,lezioni[i].Descrizione);
            }
        }
    }
}

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
    public partial class VisualizzaAssenze : Form
    {
        public VisualizzaAssenze()
        {
            InitializeComponent();
        }

        private void VisualizzaAssenze_Load(object sender, EventArgs e)
        {
            /*dataGridViewAssenze.DataSource = null;
            dataGridViewAssenze.DataSource = School.Instance.leggiAssenze();*/

            List<Assenza> assenze = new List<Assenza>();
            assenze = School.Instance.leggiAssenze();
            for (int i = 0; i < assenze.Count; i++)
            {
                dataGridViewAssenze.Rows.Add(assenze[i].Id, assenze[i].Studente,assenze[i].Data_inizio, assenze[i].Data_fine, assenze[i].Giustificato, assenze[i].Motivazione);
            }
        }
    }
}

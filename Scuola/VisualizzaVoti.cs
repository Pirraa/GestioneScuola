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
    public partial class VisualizzaVoti : Form
    {
        public VisualizzaVoti()
        {
            InitializeComponent();
        }

        private void VisualizzaVoti_Load(object sender, EventArgs e)
        {
            dataGridViewVoti.DataSource = null;
            List<Voto> voti = new List<Voto>();
            voti=School.Instance.leggiVoti();

            for(int i=0; i<voti.Count; i++)
            {
                dataGridViewVoti.Rows.Add(voti[i].Id, voti[i].Studente, voti[i].Docente, voti[i].Materia, voti[i].Votoo);
            }
            //dataGridViewVoti.DataSource = School.Instance.leggiVoti();
        }

        private void dataGridViewVoti_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewRow selectedRow = dataGridViewVoti.SelectedRows[0];
                dataGridViewVoti.Rows.RemoveAt(dataGridViewVoti.SelectedRows[0].Index);
                DataGridViewCell selectedCell = selectedRow.Cells[0];
                int indice = Convert.ToInt32(selectedCell.Value);
                School.Instance.rimuoviVoto((int)indice);
            }
        }
    }
}

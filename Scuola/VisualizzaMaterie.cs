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
    public partial class VisualizzaMaterie : Form
    {
        public VisualizzaMaterie()
        {
            InitializeComponent();
        }

        private void VisualizzaMaterie_Load(object sender, EventArgs e)
        {
            /*dataGridViewMaterie.DataSource = null;
            dataGridViewMaterie.DataSource = School.Instance.leggiMaterie();*/


            List<Materia> materie = new List<Materia>();
            materie = School.Instance.leggiMaterie();

            for (int i = 0; i < materie.Count; i++)
            {
                dataGridViewMaterie.Rows.Add(materie[i].Id, materie[i].Descrizione, materie[i].Docente);
            }
        }

        private void dataGridViewMaterie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewRow selectedRow = dataGridViewMaterie.SelectedRows[0];
                dataGridViewMaterie.Rows.RemoveAt(dataGridViewMaterie.SelectedRows[0].Index);
                DataGridViewCell selectedCell = selectedRow.Cells[0];
                int indice = Convert.ToInt32(selectedCell.Value);
                School.Instance.rimuoviMateria((int)indice);
            }
        }
    }
}

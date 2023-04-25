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
    public partial class VisualizzaClassi : Form
    {
        public VisualizzaClassi()
        {
            InitializeComponent();
        }

        private void VisualizzaClassi_Load(object sender, EventArgs e)
        {
            /*dataGridViewClassi.DataSource = null;
            dataGridViewClassi.DataSource = School.Instance.leggiClassi();*/

            List<Classe> classi = new List<Classe>();
            classi = School.Instance.leggiClassi();

            for (int i = 0; i < classi.Count; i++)
            {
                dataGridViewClassi.Rows.Add(classi[i].Id, classi[i].Sezione, classi[i].Anno);
            }
        }

        private void dataGridViewClassi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewRow selectedRow = dataGridViewClassi.SelectedRows[0];
                dataGridViewClassi.Rows.RemoveAt(dataGridViewClassi.SelectedRows[0].Index);
                DataGridViewCell selectedCell = selectedRow.Cells[0];
                int indice = Convert.ToInt32(selectedCell.Value);
                School.Instance.rimuoviClasse((int)indice);
            }
        }
    }
}

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
    public partial class AggiungiClassi : Form
    {
        public AggiungiClassi()
        {
            InitializeComponent();
        }

        private void AggiungiClassi_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                comboBoxAnno.Items.Add(i);
            }

            String[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
            comboBoxSezione.DataSource = letters;
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            School.Instance.aggiungiClasse((int)comboBoxAnno.SelectedItem, Convert.ToChar(comboBoxSezione.SelectedItem));
        }
    }
}

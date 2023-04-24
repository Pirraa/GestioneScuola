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
            dataGridViewAssenze.DataSource = null;
            dataGridViewAssenze.DataSource = School.Instance.leggiAssenze();
        }
    }
}

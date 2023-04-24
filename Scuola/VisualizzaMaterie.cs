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
            dataGridViewMaterie.DataSource = null;
            dataGridViewMaterie.DataSource = School.Instance.leggiMaterie();
        }
    }
}

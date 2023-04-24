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
            dataGridViewLezioni.DataSource = null;
            dataGridViewLezioni.DataSource = School.Instance.leggiLezioni();
        }
    }
}

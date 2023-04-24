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
            dataGridViewClassi.DataSource = null;
            dataGridViewClassi.DataSource = School.Instance.leggiClassi();
        }
    }
}

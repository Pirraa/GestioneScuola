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
    public partial class AggiungiDocente : Form
    {
        public AggiungiDocente()
        {
            InitializeComponent();
        }


        private void AggiungiDocente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            School.Instance.aggiungiDocente(txtNome.Text, txtCognome.Text, txtEmail.Text);
        }
    }
}

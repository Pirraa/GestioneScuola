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
    public partial class AggiungiMateria : Form
    {
        public AggiungiMateria()
        {
            InitializeComponent();
        }

        private void AggiungiMateria_Load(object sender, EventArgs e)
        {
            List<Docente> docenti = new List<Docente>();
            docenti = School.Instance.leggiDocenti();
            comboBoxDocente.DataSource = docenti;
            comboBoxDocente.DisplayMember = "nome";
            comboBoxDocente.ValueMember = "id";
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            School.Instance.aggiungiMateria(txtMateria.Text, (int)comboBoxDocente.SelectedValue);
        }
    }
}

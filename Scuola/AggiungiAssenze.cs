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
    public partial class AggiungiAssenze : Form
    {
        public AggiungiAssenze()
        {
            InitializeComponent();
        }



        private void AggiungiAssenze_Load(object sender, EventArgs e)
        {
            List<Studente> studenti = new List<Studente>();
            studenti = School.Instance.leggiStudenti();
            comboBoxStudente.DataSource = studenti;
            comboBoxStudente.DisplayMember = "nome";
            comboBoxStudente.ValueMember = "id";
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            School.Instance.aggiungiAssenza(Convert.ToInt32(comboBoxStudente.SelectedValue), (DateTime)dateTimePicker1.Value, (DateTime)dateTimePicker2.Value, txtMotivo.Text);
        }
    }
}

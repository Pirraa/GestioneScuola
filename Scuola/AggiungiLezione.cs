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
    public partial class AggiungiLezione : Form
    {
        public AggiungiLezione()
        {
            InitializeComponent();
        }

        private void AggiungiLezione_Load(object sender, EventArgs e)
        {
            List<Materia> materie = new List<Materia>();
            materie = School.Instance.leggiMaterie();
            comboBoxMateria.DataSource = materie;
            comboBoxMateria.DisplayMember = "descrizione";
            comboBoxMateria.ValueMember = "id";

            List<Docente> docenti = new List<Docente>();
            docenti = School.Instance.leggiDocenti();
            comboBoxDocente.DataSource = docenti;
            comboBoxDocente.DisplayMember = "nome";
            comboBoxDocente.ValueMember = "id";
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            School.Instance.aggiungiLezione((int)comboBoxDocente.SelectedValue, dateTimePicker1.Value, dateTimePicker2.Value, (int)comboBoxMateria.SelectedValue,txtDescrizione.Text);
        }
    }
}

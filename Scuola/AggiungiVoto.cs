using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Scuola
{
    public partial class AggiungiVoto : Form
    {
        public AggiungiVoto()
        {
            InitializeComponent();
        }

        private void AggiungiVoto_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBoxVoto.Items.Add(i);
            }

            List<Studente> studenti = new List<Studente>();
            studenti = School.Instance.leggiStudenti();
            comboBoxStudente.DataSource = studenti;
            comboBoxStudente.DisplayMember = "nome";
            comboBoxStudente.ValueMember = "id";

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
            School.Instance.aggiungiVoto((int)comboBoxMateria.SelectedValue, (int)comboBoxDocente.SelectedValue, (int)comboBoxStudente.SelectedValue, (int)comboBoxVoto.SelectedItem);
        }
    }
}

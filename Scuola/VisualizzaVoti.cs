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
    public partial class VisualizzaVoti : Form
    {
        public VisualizzaVoti()
        {
            InitializeComponent();
        }

        private void VisualizzaVoti_Load(object sender, EventArgs e)
        {
            dataGridViewVoti.DataSource = null;
            List<Voto> voti = new List<Voto>();
            voti=School.Instance.leggiVoti();

            for(int i=0; i<voti.Count; i++)
            {
                dataGridViewVoti.Rows.Add(voti[i].Id, voti[i].Studente, voti[i].Docente, voti[i].Materia, voti[i].Votoo);
            }
            //dataGridViewVoti.DataSource = School.Instance.leggiVoti();
        }
    }
}

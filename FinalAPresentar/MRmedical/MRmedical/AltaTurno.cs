using clasessM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRmedical
{
    public partial class AltaTurno : Form
    {
        Principal principal = new Principal();
        public AltaTurno()
        {
            InitializeComponent();
        }

        private void AltaTurno_Load(object sender, EventArgs e)
        {

        }

        private void aturno_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();
        }
    

            /*turno.pacienteTurno = textPaciente.Text;//parcear
            turno.fechaHora = DateTime.Parse(textFechaHora.Text);
            turno.medicoTurno = textMedico.Text;//parcear

            listBox1.DataSource = null;
            listBox1.DisplayMember = "T";
            listBox1.DataSource = principal.ListaTurno;

            MessageBox.Show("Turno agendado.");

            textPaciente.Clear();
            textFechaHora.();
            textMedico.Clear();
            //agregar que se pueda ver el id sin que lo ingresen por pantalla
        }

        private void Medico_TextChanged(object sender, EventArgs e)
        {

        }

        private void modturno_Click(object sender, EventArgs e)
        {
            Turno itemSeleccionado = (Turno)listBox1.SelectedItem;//ver video para que funcione

            Turno turno = new Turno();

            /*turno.pacienteTurno = textPaciente.Text;//parcear
            turno.fechaHora = DateTime.Parse(textFechaHora.Text);
            turno.medicoTurno = textMedico.Text;

            principal.ModificacionTurno( turno , itemSeleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "T";
            listBox1.DataSource = principal.ListaTurno; 
        }

        private void bajaturno_Click(object sender, EventArgs e)
        {
            Turno itemSeleccionado = (Turno)listBox1.SelectedItem;

            principal.BajaTurno(itemSeleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "T";
            listBox1.DataSource = principal.ListaTurno;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuSecretaria form = new MenuSecretaria();
            form.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/
    }
}

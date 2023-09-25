using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRnew
{
    public partial class NuevoTurno : Form
    {
        Principal principal = new Principal();
        public NuevoTurno()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void aturno_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();

            turno.pacienteTurno = textPaciente.Text;//parcear
            turno.fechaHora = DateTime.Parse(textFechaHora.Text);
            turno.medicoTurno = textMedico.Text;//parcear

            listBox1.DataSource = null;
            listBox1.DisplayMember = "T";
            listBox1.DataSource = principal.ListaTurno;

            MessageBox.Show("Turno agendado.");

            textPaciente.Clear();
            textFechaHora.Clear();
            textMedico.Clear();
            //agregar que se pueda ver el id sin que lo ingresen por pantalla
        }

        private void modturno_Click(object sender, EventArgs e)
        {
            Turno itemSeleccionado = (Turno)listBox1.SelectedItem;//ver video para que funcione

            Turno turno = new Turno();

            turno.pacienteTurno = textPaciente.Text;//parcear
            turno.fechaHora = DateTime.Parse(textFechaHora.Text);
            turno.medicoTurno = textMedico.Text;

            principal.ModificacionTurno(turno, itemSeleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "T";
            listBox1.DataSource = principal.ListaTurno;
        }

        private void elimturno_Click(object sender, EventArgs e)
        {
            Turno itemSeleccionado = (Turno)listBox1.SelectedItem;

            principal.BajaTurno(itemSeleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "T";
            listBox1.DataSource = principal.ListaTurno;

        }

        private void cancelarT_Click(object sender, EventArgs e)
        {
            MenuSecretaria form = new MenuSecretaria();
            form.Show();
            this.Hide();
        }
    }
}

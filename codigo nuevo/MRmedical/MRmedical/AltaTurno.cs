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

            turno.pacienteTurno = Paciente.Parse(textPaciente.Text);
            turno.fechaHora = DateTime.Parse(textFechaHora.Text);
            turno.medicoTurno = Medico.Parse(textMedico.Text);
        }

        private void Medico_TextChanged(object sender, EventArgs e)
        {

        }

        private void modturno_Click(object sender, EventArgs e)
        {
            Turno itemSeleccionado = (Turno)listBox1.SelectedItem;//ver video para que funcione

            Turno turno = new Turno();

            turno.pacienteTurno = Paciente.Parse(textPaciente.Text);
            turno.fechaHora = DateTime.Parse(textFechaHora.Text);
            turno.medicoTurno = Medico.Parse(textMedico.Text);

            Principal.ModificacionTurno(itemSeleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "T";
            listBox1.DataSource = Principal.ListaTurno; 
        }

        private void bajaturno_Click(object sender, EventArgs e)
        {
            Turno itemSeleccionado = (Turno)listBox1.SelectedItem;

            principal.BajaVehiculoAutomovil(itemSeleccionado);
            listBox1.DataSource = null;
            listBox1.DisplayMember = "T";
            listBox1.DataSource = principal.ListaTurno;
            
        }
    }
}

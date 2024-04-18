using BackRespaldo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalRespaldo
{
    public partial class AltaTurno : Form
    {

        Principal principal = new Principal();
        public AltaTurno()
        {
            InitializeComponent();
        }

        private void buvolver_Click(object sender, EventArgs e)
        {
            DataGridTurno turnosData = new DataGridTurno();
            turnosData.Show();
            this.Hide();
        }

        private void butGuardarturno_Click(object sender, EventArgs e)
        {
            Turno nuevoTurno = new Turno();
            nuevoTurno.fechaHora = (DateTime)PickerTurno.Value;
            nuevoTurno.medicoTurno = (Medico)comboMedico.SelectedItem;
            nuevoTurno.pacienteTurno = (Paciente)combopaciente.SelectedItem;

            principal.Altaturno(nuevoTurno);

            MessageBox.Show("El turno fue guardado");

            comboMedico.Items.Clear();
            combopaciente.Items.Clear();

        }

        private void comboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combopaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AltaTurno_Load(object sender, EventArgs e)
        {
            var medicos = principal.MostrarMedicos();
            comboMedico.Items.AddRange(medicos.ToArray());
            comboMedico.DisplayMember = "nombre";

            var pacientes = principal.MostrarPacientes();
            combopaciente.Items.AddRange(pacientes.ToArray());
            combopaciente.DisplayMember = "nombre";
            

        }
    }
}

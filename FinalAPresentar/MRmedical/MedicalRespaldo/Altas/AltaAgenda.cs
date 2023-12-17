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
    public partial class AltaAgenda : Form
    {
        Principal principal = new Principal();
        public AltaAgenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combofechanac_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {

        }

        private void comboEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtdirecc_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void butAtras_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void butAgrAgend_Click(object sender, EventArgs e)
        {
            principal.CrearAgenda((Paciente)comboPac.SelectedItem, (Medico)comboMed.SelectedItem, (Turno)comboTurno.SelectedItem);

            MessageBox.Show("Datos agregados");
            comboPac.Items.Clear();
            comboMed.Items.Clear();
            comboTurno.Items.Clear();
        }

        private void butAtras_Click_1(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            MenuSecretaria form = new MenuSecretaria();
            form.Show();
            this.Hide();
        }

        private void comboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboMed_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboPac_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void AltaAgenda_Load(object sender, EventArgs e)
        {
            var pacientes = principal.MostrarPacientes();
            comboPac.Items.AddRange(pacientes.ToArray());
            comboPac.DisplayMember = "nombre";

            var medicos = principal.MostrarAgenda();
            comboMed.Items.AddRange(medicos.ToArray());
            comboMed.DisplayMember = "nombre";

            var turnos = principal.MostrarTurnos();
            comboTurno.Items.AddRange(turnos.ToArray());
            comboTurno.DisplayMember = "fechaHora";
        }
    }
    
}

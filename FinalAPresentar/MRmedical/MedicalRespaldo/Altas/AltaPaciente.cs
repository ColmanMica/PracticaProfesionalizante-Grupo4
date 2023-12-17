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
    public partial class AltaPaciente : Form
    {
        Principal principal = new Principal();
        public AltaPaciente()
        {
            InitializeComponent();
        }

        private void butatras_Click(object sender, EventArgs e)
        {
            DataGridPaciente pacientesData = new DataGridPaciente();
            pacientesData.Show();
            this.Hide();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            Paciente nuevoPaciente = new Paciente();
            nuevoPaciente.dni = int.Parse(txtdni.Text);
            nuevoPaciente.nombre = txtnombre.Text;
            nuevoPaciente.apellido = txtapellido.Text;
            nuevoPaciente.fechaNacimiento = (DateTime)TimePickerFechanac.Value;
            nuevoPaciente.direccion = txtdirecc.Text;
            nuevoPaciente.vacunasAlDia = bool.Parse(combovacunas.SelectedItem.ToString());

            principal.AltaPaciente(nuevoPaciente);

            MessageBox.Show(" El paciente fue guardado");

            
            txtdni.Clear();
            txtnombre.Clear();
            txtdirecc.Clear();
            txtapellido.Clear();

        }

        private void AltaPaciente_Load(object sender, EventArgs e)
        {
            combovacunas.Items.Add("Si");
            combovacunas.Items.Add("No");
        }
    }
}

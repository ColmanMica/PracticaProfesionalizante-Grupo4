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
    public partial class AltaPaciente : Form
    {
        Principal principal = new Principal();
        public AltaPaciente()
        {
            InitializeComponent();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            Paciente nuevoPaciente = new Paciente();
            nuevoPaciente.dni = int.Parse(txtdni.Text);
            nuevoPaciente.nombre = txtnombre.Text;
            nuevoPaciente.apellido = txtapellido.Text;
            nuevoPaciente.fechaNacimiento = (DateTime)combofechanac.SelectedItem;
            nuevoPaciente.direccion = txtdirecc.Text;
            nuevoPaciente.vacunasAlDia = bool.Parse(txtvacuna.Text);

            principal.AltaPaciente(nuevoPaciente);

            MessageBox.Show(" El paciente fue guardado");

            txtvacuna.Clear();
            txtdni.Clear();
            txtnombre.Clear();
            txtdirecc.Clear();
            combofechanac.Items.Clear();
            txtapellido.Clear();

        }

        private void butatras_Click(object sender, EventArgs e)
        {
            PacientesData pacientesData = new PacientesData();
            pacientesData.Show();
            this.Hide();

        }

        private void AltaPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}

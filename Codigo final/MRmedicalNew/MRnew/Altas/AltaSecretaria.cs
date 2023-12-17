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
    public partial class AltaSecretaria : Form
    {
        Principal principal = new Principal();
        public AltaSecretaria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Secretaria nuevaSecretaria = new Secretaria();
            nuevaSecretaria.numerolegajo = int.Parse(txtnumlegajo.Text);
            nuevaSecretaria.dni = int.Parse(txtdni.Text);
            nuevaSecretaria.nombre = txtnombre.Text;
            nuevaSecretaria.apellido = txtapellido.Text;
            nuevaSecretaria.fechaNacimiento = (DateTime)combofechanac.SelectedItem;
            nuevaSecretaria.direccion = txtndirecc.Text;

            principal.AltaSecretaria(nuevaSecretaria);

            MessageBox.Show("El paciente fue guardado");
            txtnumlegajo.Clear();
            txtdni.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            combofechanac.Items.Clear();
            txtndirecc.Clear();
        }

        private void butatras_Click(object sender, EventArgs e)
        {

        }

        private void combofechanac_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtndirecc_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtnumlegajo_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AltaSecretaria_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class AltaSecretaria : Form
    {
        Principal principal = new Principal();
        public AltaSecretaria()
        {
            InitializeComponent();
        }

        private void butguardarsecret_Click(object sender, EventArgs e)
        {
            Secretaria nuevaSecretaria = new Secretaria();
            nuevaSecretaria.numerolegajo = int.Parse(txtnumlegajo.Text);
            nuevaSecretaria.dni = int.Parse(txtdni.Text);
            nuevaSecretaria.nombre = txtnombre.Text;
            nuevaSecretaria.apellido = txtapellido.Text;
            nuevaSecretaria.fechaNacimiento = (DateTime)PickerFechaNac.Value;
            nuevaSecretaria.direccion = txtndirecc.Text;

            principal.AltaSecretaria(nuevaSecretaria);

            MessageBox.Show("El paciente fue guardado");
            txtnumlegajo.Clear();
            txtdni.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtndirecc.Clear();
        }

        private void butatras_Click(object sender, EventArgs e)
        {
            MenuSecretaria form = new MenuSecretaria();
            form.Show();
            this.Hide();
        }
    }
}

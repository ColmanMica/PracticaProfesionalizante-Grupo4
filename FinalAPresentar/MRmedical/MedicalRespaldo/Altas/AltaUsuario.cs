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
    public partial class AltaUsuario : Form
    {
        Principal principal = new Principal();
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogUsuario usuario = new LogUsuario();
            usuario.Show();
            this.Hide();
        }

        private void butRegistro_Click(object sender, EventArgs e)
        {
            principal.AltaUsuario(txtBoxCorreo.Text, txtBoxContrasenia.Text, comboTipo.SelectedItem.ToString());

            using (var context = new BaseDeDatosApp())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.correo == txtBoxCorreo.Text);

                if (usuario != null && usuario.contrasenia == txtBoxContrasenia.Text)
                {
                    if (comboTipo.Text == "secretaria")
                    {
                        usuario.tipo = comboTipo.SelectedItem.ToString();
                    }
                    else
                    {
                        if (comboTipo.Text == "medico")
                        {
                            usuario.tipo = comboTipo.SelectedItem.ToString();
                        }
                        else
                        {
                            MessageBox.Show("El tipo imgresado es incorrecto");
                        }
                    }

                }
                context.SaveChanges();
                MessageBox.Show("Usuario registrado con exito");
                txtBoxCorreo.Clear();
                txtBoxContrasenia.Clear();
                //comboTipo.();
            }
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            comboTipo.Items.Add("Medico");
            comboTipo.Items.Add("Secretaria");

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

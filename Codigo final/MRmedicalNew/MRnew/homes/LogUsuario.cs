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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MRnew
{
    public partial class LogUsuario : Form
    {
        Principal principal = new Principal();
        public LogUsuario()
        {
            InitializeComponent();
        }

        private void ingresoUsuario_Click(object sender, EventArgs e)
        {

            {
                using (var context = new BaseDeDatosApp())
                {
                    var usuario = context.Usuarios.FirstOrDefault(u => u.correo == txtBoxCorreo.Text);

                    if (usuario != null && usuario.contrasenia == txtBoxContrasenia.Text)
                    {

                        if (usuario.tipo == "secretaria")
                        {
                            MenuSecretaria form = new MenuSecretaria();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MenuMedico form = new MenuMedico();
                            form.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña son incorrectos");
                    }
                    txtBoxCorreo.Clear();
                    txtBoxContrasenia.Clear();
                }



            }



        }

        private void butRegistro_Click(object sender, EventArgs e)
        {





        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logUsuario2 form = new logUsuario2();
            form.Show();
            this.Hide();
        }

        private void butatrasLog_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
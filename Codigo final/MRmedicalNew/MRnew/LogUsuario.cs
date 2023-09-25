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
    public partial class LogUsuario : Form
    {
        public LogUsuario()
        {
            InitializeComponent();
        }

        private void ingresoUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario.correo == txtBoxCorreo.Text)
            {
                if (usuario.contrasenia == txtBoxContrasenia.Text)
                {

                    if (usuario.tipo == "Secretaria")
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
                    MessageBox.Show("Contrasenia Incorrecta");//return false;//Contrasenia invalida
                }
            }
            MessageBox.Show("El usuario no existe");//Usuario invalido



        }
    }
}

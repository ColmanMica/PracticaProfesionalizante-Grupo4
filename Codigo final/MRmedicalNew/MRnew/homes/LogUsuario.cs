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
            Usuario usuario = new Usuario(); // ver validacion y persistencia de datos
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

        private void butRegistro_Click(object sender, EventArgs e)
        {
            principal.AltaUsuario(txtBoxCorreo.Text, txtBoxContrasenia.Text, txtTipo.Text);
            Validate(); //validacion manual

            Usuario usuario = new Usuario();

           if (txtTipo.Text == "Secretaria")
             {
                usuario.tipo = txtTipo.Text;
             }
             else
             {
               if (txtTipo.Text == "Medico")
                {
                    usuario.tipo = txtTipo.Text;
                }
                else 
                {
                    MessageBox.Show("El tipo imgresado es incorrecto");
                }


              }
                    MessageBox.Show("Usuario registrado con exito");

              
        }

        
    }
}
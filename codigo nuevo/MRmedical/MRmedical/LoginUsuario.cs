using clasessM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRmedical
{
    public partial class LoginUsuario : Form
    { 
        Principal principal = new Principal();
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {













































































































        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            if (usuario.correo == txtBoxCorreo.Text)
            {
                if (usuario.contrasenia == txtBoxContrasenia.Text)
                {
                        
                    if (Secretaria != null)//si secretaria no es nulo
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

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
    public partial class logUsuario2 : Form
    {
        Principal principal = new Principal();
        public logUsuario2()
        {
            InitializeComponent();
        }

        private void ingresoUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            principal.ModificarUsuario(usuario);
        }

        private void butRegistro_Click(object sender, EventArgs e)
        {
            principal.AltaUsuario(txtBoxCorreo.Text, txtBoxContrasenia.Text, txtTipo.Text);
            Validate(); //validacion manual

            Usuario usuario = new Usuario();

            if (txtTipo.Text == "secretaria")
            {
                usuario.tipo = txtTipo.Text;
            }
            else
            {
                if (txtTipo.Text == "medico")
                {
                    usuario.tipo = txtTipo.Text;
                }
                else
                {
                    MessageBox.Show("El tipo imgresado es incorrecto");
                }
            }
            //generar un bucle hasta que sea el correcto y despues el mensaje de registro correcto
            MessageBox.Show("Usuario registrado con exito");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logUsuario2_Load(object sender, EventArgs e)
        {

        }
    }
}

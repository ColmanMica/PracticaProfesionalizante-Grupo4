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
    public partial class UsuariosData : Form
    {
        Principal principal = new Principal();
        public UsuariosData()
        {
            InitializeComponent();
        }

        private void UsuariosData_Load(object sender, EventArgs e)
        {
            dataGridUsuarios.DataSource = new BindingList<Usuario>(principal.MostrarUsuarios());

        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.MostrarUsuarios();
            dataGridUsuarios.DataSource = aBind;

        }

        private void modUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario UserSeleccionado = (Usuario)dataGridUsuarios.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este usuario?", "Usuario eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarUsuario(UserSeleccionado);
            }


        }

        private void butModUsuario_Click(object sender, EventArgs e)
        {
            Usuario UserSeleccionado = (Usuario)dataGridUsuarios.CurrentRow.DataBoundItem;

            principal.ModificarUsuario(UserSeleccionado);
        }

        private void butAtrasU_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Close();
        }
    }
}

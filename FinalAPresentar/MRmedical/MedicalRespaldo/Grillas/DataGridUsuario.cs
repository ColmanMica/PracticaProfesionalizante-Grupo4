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
    public partial class DataGridUsuario : Form
    {
        Principal principal = new Principal();
        public DataGridUsuario()
        {
            InitializeComponent();
        }

        private void butAtrasU_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void butModUsuario_Click(object sender, EventArgs e)
        {
            Usuario UserSeleccionado = (Usuario)dataGridUsuarios.CurrentRow.DataBoundItem;

            principal.ModificarUsuario(UserSeleccionado);
        }

        private void butElimUser_Click(object sender, EventArgs e)
        {
            Usuario UserSeleccionado = (Usuario)dataGridUsuarios.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este usuario?", "Usuario eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarUsuario(UserSeleccionado);
            }

        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            /*BindingSource aBind = new BindingSource();
            aBind.DataSource = 
            dataGridUsuarios.DataSource = aBind;*/
        }

        private void DataGridUsuario_Load(object sender, EventArgs e)
        {
            dataGridUsuarios.DataSource = new BindingList<Usuario>(principal.MostrarUsuarios());
        }
    }
}

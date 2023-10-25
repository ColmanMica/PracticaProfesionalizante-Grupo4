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


        }

        private void modUsuario_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //principal.EliminarUsuario(); //hacer que tome el usuario
        }
    }
}

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
    public partial class ABMespecialidad : Form
    {
        Principal principal = new Principal();
        public ABMespecialidad()
        {
            InitializeComponent();
        }

        private void ABMespecialidad_Load(object sender, EventArgs e)
        {
            dataGridEspecialidades.DataSource = new BindingList<Especialidad>(principal.MostrarEspecialidades());



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.MostrarEspecialidades();
            dataGridEspecialidades.DataSource = aBind;
        }

        private void butModEspec_Click(object sender, EventArgs e)
        {
            /*Especialidad UserSeleccionado = (Especialidad)dataGridEspecialidades.CurrentRow.DataBoundItem;

            principal.ModificarEspecialidad(UserSeleccionado);*/
        }

        private void butEliminarespec_Click(object sender, EventArgs e)
        {

        }

        private void butAtras_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Close();
        }
    }
}

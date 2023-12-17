using Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRnew
{
    public partial class DataSecretaria : Form
    {
        Principal principal = new Principal();
        public DataSecretaria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secretaria seceretariaSeleccionada = (Secretaria)dataGridSecretaria.CurrentRow.DataBoundItem;

            principal.ModificarSecretaria(seceretariaSeleccionada);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Secretaria seceretariaSeleccionada = (Secretaria)dataGridSecretaria.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar Secretaria?", "Secretaria eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarSecretaria(seceretariaSeleccionada);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaSecretaria form = new AltaSecretaria();
            form.Show();
            this.Hide();
        }

        private void DataSecretaria_Load(object sender, EventArgs e)
        {

            dataGridSecretaria.DataSource = new BindingList<Secretaria>(principal.MostrarSecretarias());

        }

        private void dataGridSecretaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.MostrarSecretarias();
            dataGridSecretaria.DataSource = aBind;
        }
    }
}

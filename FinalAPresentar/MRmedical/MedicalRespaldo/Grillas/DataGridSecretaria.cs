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
    public partial class DataGridSecretaria : Form
    {
        Principal principal = new Principal();
        public DataGridSecretaria()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaSecretaria form = new AltaSecretaria();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Secretaria seceretariaSeleccionada = (Secretaria)dataGridS.CurrentRow.DataBoundItem;

            principal.ModificarSecretaria(seceretariaSeleccionada);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Secretaria seceretariaSeleccionada = (Secretaria)dataGridS.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar Secretaria?", "Secretaria eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarSecretaria(seceretariaSeleccionada);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*BindingSource aBind = new BindingSource();
            aBind.DataSource = secretariaBindingSource;
            dataGridS.DataSource = aBind;*/
        }

        private void DataGridSecretaria_Load(object sender, EventArgs e)
        {
            dataGridS.DataSource = new BindingList<Secretaria>(principal.MostrarSecretarias());
        }
    }
}

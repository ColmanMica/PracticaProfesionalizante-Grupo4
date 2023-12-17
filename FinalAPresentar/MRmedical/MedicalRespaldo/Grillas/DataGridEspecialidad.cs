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
    public partial class DataGridEspecialidad : Form
    {
        Principal principal = new Principal();
        public DataGridEspecialidad()
        {
            InitializeComponent();
        }

        private void butAtras_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void dataGridEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*BindingSource aBind = new BindingSource();
            aBind.DataSource = especialidadBindingSource;
            dataGridEspecialidades.DataSource = aBind;*/
        }

        private void DataGridEspecialidad_Load(object sender, EventArgs e)
        {
            dataGridEspecialidades.DataSource = new BindingList<Especialidad>(principal.MostrarEspecialidades());
        }
    }
}

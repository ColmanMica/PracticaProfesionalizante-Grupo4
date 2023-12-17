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
    public partial class DataGridPaciente : Form
    {
        Principal principal = new Principal();
        public DataGridPaciente()
        {
            InitializeComponent();
        }

        private void butatrasp_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaPaciente altaPaciente = new AltaPaciente();
            altaPaciente.Show();
            this.Hide();
        }

        private void butMosPaciente_Click(object sender, EventArgs e)
        {
            Paciente UserSeleccionado = (Paciente)dataGridPte.CurrentRow.DataBoundItem;

            principal.ActualizarPaciente(UserSeleccionado);
        }

        private void butElimPaciente_Click(object sender, EventArgs e)
        {
            Paciente UserSeleccionado = (Paciente)dataGridPte.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este paciente?", "Paciente eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarPaciente(UserSeleccionado);
            }
        }

        private void dataGridPte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* BindingSource aBind = new BindingSource();
            aBind.DataSource = pacienteBindingSource;
            dataGridPte.DataSource = aBind;*/
        }

        private void DataGridPaciente_Load(object sender, EventArgs e)
        {
            dataGridPte.DataSource = new BindingList<Paciente>(principal.MostrarPacientes());
        }
    }
}

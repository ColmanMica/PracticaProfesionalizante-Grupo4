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
    public partial class PacientesData : Form
    {
        Principal principal = new Principal();
        public PacientesData()
        {
            InitializeComponent();
        }

        private void PacientesData_Load(object sender, EventArgs e)
        {
            dataGridPaciente.DataSource = new BindingList<Paciente>(principal.MostrarPacientes()); ;
        }

        private void butMosPaciente_Click(object sender, EventArgs e)
        {
            Paciente UserSeleccionado = (Paciente)dataGridPaciente.CurrentRow.DataBoundItem;

            principal.ActualizarPaciente(UserSeleccionado);
        }

        private void butElimPaciente_Click(object sender, EventArgs e)
        {
            Paciente UserSeleccionado = (Paciente)dataGridPaciente.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este paciente?", "Paciente eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarPaciente(UserSeleccionado);
            }
        }

        private void butatrasp_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaPaciente altaPaciente = new AltaPaciente();
            altaPaciente.Show();
            this.Close();
        }

        private void dataGridPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.MostrarPacientes();
            dataGridPaciente.DataSource = aBind;
        }
    }
}

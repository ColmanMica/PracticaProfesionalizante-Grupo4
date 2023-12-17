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
    public partial class DataGridHistorial : Form
    {
        Principal principal = new Principal();
        public DataGridHistorial()
        {
            InitializeComponent();
        }

        private void butAtras_Click(object sender, EventArgs e)
        {
            MenuMedico menuMedico = new MenuMedico();
            menuMedico.Show();
            this.Hide();
        }

        private void butVS_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void buthardarHist_Click(object sender, EventArgs e)
        {
            AltaHistorial nuevoHistorial = new AltaHistorial();
            nuevoHistorial.Show();
            this.Hide();
        }

        private void butModHist_Click(object sender, EventArgs e)
        {
            Historial UserSeleccionado = (Historial)dataGridHist.CurrentRow.DataBoundItem;

            principal.ActualizarHistorial(UserSeleccionado);
        }

        private void butElimHist_Click(object sender, EventArgs e)
        {
            Historial UserSeleccionado = (Historial)dataGridHist.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este historial?", "Historial eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarHistorial(UserSeleccionado);
            }
        }

        private void dataGridHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*BindingSource aBind = new BindingSource();
            aBind.DataSource = historialBindingSource;
            dataGridHist.DataSource = aBind;*/
        }

        private void DataGridHistorial_Load(object sender, EventArgs e)
        {
            dataGridHist.DataSource = new BindingList<Historial>(principal.MostrarHistoriales());
            ((DataGridViewComboBoxColumn)dataGridHist.Columns["pacientecolum"]).DataSource = principal.MostrarPacientes().ToArray();

        }

        private void dataGridHist_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string pacienteString = e.Value.ToString();

                Paciente laElegida = principal.MostrarPacientes().FirstOrDefault<Paciente>(paciente => paciente.nombre == pacienteString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
        }
    }
}

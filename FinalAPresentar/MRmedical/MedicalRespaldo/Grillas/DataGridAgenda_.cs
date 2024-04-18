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
    public partial class DataGridAgenda_ : Form
    {
        Principal principal = new Principal();
        public DataGridAgenda_()
        {
            InitializeComponent();

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            DataGridTurno turnosData = new DataGridTurno();
            turnosData.Show();
            this.Hide();
        }

        private void DataGridAgenda__Load(object sender, EventArgs e)
        {
            dataGridAgenda.DataSource = new BindingList<Agenda>(principal.MostrarAgenda());

            //paciente
            //var pacientes = principal.MostrarPacientes();
            /*((DataGridViewComboBoxColumn)dataGridAgenda.Columns["pacienteColumm"]).DataSource = principal.MostrarPacientes();
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["pacienteColumm"]).DataSource = "nombre";
            //medico
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["medicoColumm"]).DataSource = principal.MostrarMedicos();
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["medicoColumm"]).DataSource = "nombre";
            //fecha
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["fechaHoraColumm"]).DataSource = principal.MostrarTurnos();
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["fechaHoraColumm"]).DataSource = "fechaHora";*/
        }

        private void menuSecretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void menuMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuMedico menuMedico = new MenuMedico();
            menuMedico.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agenda UserSeleccionado = (Agenda)dataGridAgenda.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar esta agenda?", "Agenda eliminada", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarAgenda(UserSeleccionado);
            }
        }

        private void butModicar_Click(object sender, EventArgs e)
        {
            Agenda UserSeleccionado = (Agenda)dataGridAgenda.CurrentRow.DataBoundItem;

            principal.ModificarAgenda(UserSeleccionado);

        }

        private void dataGridAgenda_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string pacienteString = e.Value.ToString();

                Paciente laElegida = principal.MostrarPacientes().FirstOrDefault<Paciente>(paciente => paciente.nombre == pacienteString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
            if (e.ColumnIndex == 2)
            {
                string turnoString = e.Value.ToString();

                Turno laElegida = principal.MostrarTurnos().FirstOrDefault<Turno>(turno => turno.fechaHora == DateTime.Parse(turnoString));

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
            if (e.ColumnIndex == 3)
            {
                string medicoString = e.Value.ToString();

                Medico laElegida = principal.MostrarMedicos().FirstOrDefault<Medico>(medico => medico.nombre == medicoString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
        }

        private void dataGridAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.MostrarAgenda();
            dataGridAgenda.DataSource = aBind;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

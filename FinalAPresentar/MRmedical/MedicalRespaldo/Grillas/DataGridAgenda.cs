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
    public partial class DataGridAgenda : Form
    {
        Principal principal = new Principal();
        public DataGridAgenda()
        {
            InitializeComponent();
        }

        private void butAMenus_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void butMenuMed_Click(object sender, EventArgs e)
        {
            MenuMedico menuMedico = new MenuMedico();
            menuMedico.Show();
            this.Hide();
        }

        private void butnewTurno_Click(object sender, EventArgs e)
        {
            DataGridTurno turnosData = new DataGridTurno();
            turnosData.Show();
            this.Hide();
        }

        private void butModAgend_Click(object sender, EventArgs e)
        {
            Agenda UserSeleccionado = (Agenda)dataGridView1.CurrentRow.DataBoundItem;

            principal.ModificarAgenda(UserSeleccionado);
        }

        private void butElimAgend_Click(object sender, EventArgs e)
        {
            Agenda UserSeleccionado = (Agenda)dataGridView1.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar esta agenda?", "Agenda eliminada", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarAgenda(UserSeleccionado);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /*BindingSource aBind = new BindingSource();
            aBind.DataSource = agendaBindingSource ;
            dataGridView1.DataSource = aBind;*/
        }

        private void DataGridAgenda_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingList<Agenda>(principal.MostrarAgenda());


            /*var especialidades = principal.MostrarEspecialidades();
            comboEspecialidades.Items.AddRange(especialidades.ToArray());
            comboEspecialidades.DisplayMember = "nombre";*/


            /*paciente
            var pacientes = principal.MostrarPacientes();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["pacienteColumm"]).DataSource = pacientes.ToArray();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["pacienteColumm"]).DataSource = "nombre y apellido";
            //medico
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["medicoColumm"]).DataSource = principal.MostrarMedicos();
            //fecha
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["fechaHoraColumm"]).DataSource = principal.MostrarTurnos();
            //((DataGridViewComboBoxColumn)dataGridView1.Columns["fechaHoraColumm"]).DataSource = "fechaHora";*/
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

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            /*if (e.ColumnIndex == 6)
            {
                string especialidadString = e.Value.ToString();

                Especialidad laElegida = principal.MostrarEspecialidades().FirstOrDefault<Especialidad>(especialidad => especialidad.nombre == especialidadString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }*/
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
    }
}

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
    public partial class AgendaData : Form
    {
        Principal principal = new Principal();
        public AgendaData()
        {
            InitializeComponent();
        }

        private void dataGridAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var agenda = new Agenda();
            BindingSource aBind = new BindingSource();
            aBind.DataSource = agenda;
            dataGridAgenda.DataSource = aBind;
        }

        private void AgendaData_Load(object sender, EventArgs e)
        {
            dataGridAgenda.DataSource = new BindingList<Agenda>(principal.MostrarAgenda());
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["pacienteColumm"]).DataSource = principal.MostrarPacientes();
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["medicoColumn"]).DataSource = principal.MostrarMedicos();
            

            //paciente
            /*((DataGridViewComboBoxColumn)dataGridAgenda.Columns["pacienteColumm"]).DataSource = principal.MostrarPacientes();
                //medico
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["medicoColumm"]).DataSource = principal.MostrarMedicos();
                  //fecha
            ((DataGridViewComboBoxColumn)dataGridAgenda.Columns["fechaHoraColumm"]).DataSource = principal.MostrarTurnos();*/
        }

        private void butModAgend_Click(object sender, EventArgs e)
        {
            Agenda UserSeleccionado = (Agenda)dataGridAgenda.CurrentRow.DataBoundItem;

            principal.ModificarAgenda(UserSeleccionado);
        }

        private void butElimAgend_Click(object sender, EventArgs e)
        {
            Agenda UserSeleccionado = (Agenda)dataGridAgenda.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar esta agenda?", "Agenda eliminada", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarAgenda(UserSeleccionado);
            }
        }

        private void dataGridAgenda_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            //paciente
            if (e.ColumnIndex == 0)
            {
                string pacienteString = e.Value.ToString();

                Paciente pElegido = principal.MostrarPacientes().FirstOrDefault<Paciente>(paciente => paciente.nombre == pacienteString);

                e.Value = pElegido;
                e.ParsingApplied = true;
                return;
            }
            if (e.ColumnIndex == 0)
            {
                string medicoString = e.Value.ToString();

                Medico mElegido = principal.MostrarMedicos().FirstOrDefault<Medico>(medico => medico.apellido == medicoString);

                e.Value = mElegido;
                e.ParsingApplied = true;
                return;
            }
            if (e.ColumnIndex == 0)
            {
                DateTime turnoDatetime = e.ParsingApplied ? DateTime.Now : DateTime.MinValue;

                Turno tElegido = principal.MostrarTurnos().FirstOrDefault<Turno>(turno => turno.fechaHora == turnoDatetime);

                e.Value = tElegido;
                e.ParsingApplied = true;
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Close();
        }

        private void butMenuMed_Click(object sender, EventArgs e)
        {
            MenuMedico menuMedico = new MenuMedico();
            menuMedico.Show();
            this.Close();
        }

        private void butnewTurno_Click(object sender, EventArgs e)
        {
            TurnosData turnosData = new TurnosData();
            turnosData.Show();
            this.Hide();

        }

        private void butAgregar_Click(object sender, EventArgs e)
        {


        }
    }
}

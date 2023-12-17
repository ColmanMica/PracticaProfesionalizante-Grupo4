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
    public partial class TurnosData : Form
    {
        Principal principal = new Principal();
        public TurnosData()
        {
            InitializeComponent();
        }

        private void TurnosData_Load(object sender, EventArgs e)
        {
            dataGridTurno.DataSource = new BindingList<Turno>(principal.MostrarTurnos());
            ((DataGridViewComboBoxColumn)dataGridTurno.Columns["medicoColumn"]).DataSource = principal.MostrarMedicos();
            ((DataGridViewComboBoxColumn)dataGridTurno.Columns["pacienteColumm"]).DataSource = principal.MostrarPacientes();
        }

        private void dataGridTurno_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string MedicoString = e.Value.ToString();

                Medico laElegida = principal.MostrarMedicos().FirstOrDefault<Medico>(med => med.nombre == MedicoString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
            if (e.ColumnIndex == 0)
            {
                string pacienteString = e.Value.ToString();

                Paciente pElegido = principal.MostrarPacientes().FirstOrDefault<Paciente>(paciente => paciente.nombre == pacienteString);

                e.Value = pElegido;
                e.ParsingApplied = true;
                return;
            }

        }

        private void dataGridTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.MostrarTurnos();
            dataGridTurno.DataSource = aBind;
        }

        private void butModTurno_Click(object sender, EventArgs e)
        {
            Turno UserSeleccionado = (Turno)dataGridTurno.CurrentRow.DataBoundItem;

            principal.ModificarTurno(UserSeleccionado);
        }

        private void butElimMed_Click(object sender, EventArgs e)
        {
            Turno UserSeleccionado = (Turno)dataGridTurno.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este turno?", "Turno eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarTurno(UserSeleccionado);
            }
        }

        private void buttAtras_Click(object sender, EventArgs e)
        {
            AgendaData agenda = new AgendaData();
            agenda.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoTurno nuevoT = new NuevoTurno();
            nuevoT.Show();
            this.Hide();
        }
    }
}


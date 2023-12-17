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
    public partial class DataGridTurno : Form
    {
        Principal principal = new Principal();
        public DataGridTurno()
        {
            InitializeComponent();
        }

        private void buttAtras_Click(object sender, EventArgs e)
        {
            MenuSecretaria menusec = new MenuSecretaria();
            menusec.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaTurno nuevoT = new AltaTurno();
            nuevoT.Show();
            this.Hide();
        }

        private void butModTurno_Click(object sender, EventArgs e)
        {
            Turno UserSeleccionado = (Turno)dataGridT.CurrentRow.DataBoundItem;

            principal.ModificarTurno(UserSeleccionado);
        }

        private void butElimMed_Click(object sender, EventArgs e)
        {
            Turno UserSeleccionado = (Turno)dataGridT.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este turno?", "Turno eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarTurno(UserSeleccionado);
            }
        }

        private void dataGridT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* BindingSource aBind = new BindingSource();
            aBind.DataSource = turnoBindingSource;
            dataGridT.DataSource = aBind;*/
        }

        private void DataGridTurno_Load(object sender, EventArgs e)
        {
            dataGridT.DataSource = new BindingList<Turno>(principal.MostrarTurnos());
            ((DataGridViewComboBoxColumn)dataGridT.Columns["medicoColumn"]).DataSource = principal.MostrarMedicos().ToArray();
            ((DataGridViewComboBoxColumn)dataGridT.Columns["pacienteColumn"]).DataSource = principal.MostrarPacientes().ToArray();
        }

        private void dataGridT_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string MedicoString = e.Value.ToString();

                Medico laElegida = principal.MostrarMedicos().FirstOrDefault<Medico>(med => med.apellido == MedicoString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
            if (e.ColumnIndex == 1)
            {
                string pacienteString = e.Value.ToString();

                Paciente pElegido = principal.MostrarPacientes().FirstOrDefault<Paciente>(paciente => paciente.apellido == pacienteString);

                e.Value = pElegido;
                e.ParsingApplied = true;
                return;
            }
        }
    }
}

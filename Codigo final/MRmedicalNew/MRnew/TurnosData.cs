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
        }

        private void dataGridTurno_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string MedicoString = e.Value.ToString();

                Medico laElegida =
                    principal.MostrarMedicos().FirstOrDefault<Medico>(med => med.nombre == MedicoString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
        }
    }
}

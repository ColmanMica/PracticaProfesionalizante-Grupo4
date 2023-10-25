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
    public partial class AMBMedico : Form
    {
        Principal principal = new Principal();
        public AMBMedico()
        {
            InitializeComponent();
        }

        private void AMBMedico_Load(object sender, EventArgs e)
        {
            dataGridMedico.DataSource = new BindingList<Medico>(principal.MostrarMedicos());
            ((DataGridViewComboBoxColumn)dataGridMedico.Columns["especColumn"]).DataSource = principal.MostrarEspecialidades();
        }

        private void dataGridMedico_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            // Acá estoy por ver los valores que hay en la celda para llenar mi objeto del tipo especialidad
            if (e.ColumnIndex == 0)
            {
                string especialidadString = e.Value.ToString();

                Especialidad laElegida =
                    principal.MostrarEspecialidades().FirstOrDefault<Especialidad>(especialidad => especialidad.nombre == especialidadString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
        }

        private void dataGridMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

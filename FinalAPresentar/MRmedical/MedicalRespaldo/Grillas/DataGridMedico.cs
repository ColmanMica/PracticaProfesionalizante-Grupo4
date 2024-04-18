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
    public partial class DataGridMedico : Form
    {
        Principal principal = new Principal();
        public DataGridMedico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void butAgrMed_Click(object sender, EventArgs e)
        {
            AltaMedico altaMedico = new AltaMedico();
            altaMedico.Show();
            this.Hide();
        }

        private void butModMed_Click(object sender, EventArgs e)
        {
            Medico UserSeleccionado = (Medico)DataGridView1.CurrentRow.DataBoundItem;

            //((BindingList<Paciente>)dataGridHist.DataSource).ResetBindings();
        }

        private void butElimMed_Click(object sender, EventArgs e)
        {
            Medico UserSeleccionado = (Medico)DataGridView1.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este Medico?", "Medico eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarMedico(UserSeleccionado);
                
            }

            //((BindingList<Paciente>)dataGridHist.DataSource).ResetBindings();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.MostrarMedicos();
            DataGridView1.DataSource = aBind;
        }

        private void DataGridMedico_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = new BindingList<Medico>(principal.MostrarMedicos());
            
            ((DataGridViewComboBoxColumn)DataGridView1.Columns["especialidadColumn"]).DataSource = principal.MostrarEspecialidades();

        }

        private void DataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            // Acá estoy por ver los valores que hay en la celda para llenar mi objeto del tipo especialidad
            if (e.ColumnIndex == 7)
            {
                string especialidadString = e.Value.ToString();

                Especialidad laElegida = principal.MostrarEspecialidades().FirstOrDefault<Especialidad>(especialidad => especialidad.nombre == especialidadString);

                e.Value = laElegida;
                e.ParsingApplied = true;
                return;
            }
        }
    }
}

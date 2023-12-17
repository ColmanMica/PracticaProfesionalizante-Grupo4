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
    public partial class RegistroAgenda : Form
    {
        Principal principal = new Principal();
        public RegistroAgenda()
        {
            InitializeComponent();
        }

        private void RegistroAgenda_Load(object sender, EventArgs e)
        {

        }

        private void butAgrAgend_Click(object sender, EventArgs e)
        {
            principal.CrearAgenda((Paciente)comboPac.SelectedItem, (Medico)comboMed.SelectedItem, (Turno)comboTurno.SelectedItem);

            MessageBox.Show("Datos agregados");
            comboPac.Items.Clear();
            comboMed.Items.Clear();
            comboTurno.Items.Clear();


        }

        private void butAtras_Click(object sender, EventArgs e)
        {

        }
    }
}

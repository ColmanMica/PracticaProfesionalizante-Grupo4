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
    public partial class NuevoTurno : Form
    {
        Principal Principal = new Principal();
        public NuevoTurno()
        {
            InitializeComponent();
        }

        private void buvolver_Click(object sender, EventArgs e)
        {
            TurnosData turnosData = new TurnosData();
            turnosData.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turno nuevoTurno = new Turno();
            nuevoTurno.fechaHora = (DateTime)combodatetime.SelectedItem;
            nuevoTurno.medicoTurno = (Medico)comboMedico.SelectedItem;
            nuevoTurno.pacienteTurno = (Paciente)combopaciente.SelectedItem;

            Principal.Altaturno(nuevoTurno);

            MessageBox.Show("El turno fue guardado");
            combodatetime.Items.Clear();
            comboMedico.Items.Clear();
            combopaciente.Items.Clear();

        }
    }
}

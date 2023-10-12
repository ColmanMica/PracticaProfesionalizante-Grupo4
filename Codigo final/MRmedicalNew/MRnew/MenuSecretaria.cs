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
    public partial class MenuSecretaria : Form
    {
        public MenuSecretaria()
        {
            InitializeComponent();
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoTurno form = new NuevoTurno();
            form.Show();
            this.Hide();
        }

        private void stafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMedico form = new AltaMedico();
            form.Show();
            this.Hide();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaData form = new AgendaData();
            form.Show();
            this.Hide();
            //despues de ver la grilla ahi deberia poder agrgar los turnos
        }

        private void altaPAcienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMespecialidad form = new ABMespecialidad();
            form.Show();
            this.Hide();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deberia hacer lo mismo con la agenda y dar las altas desde el datagride
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // hacer la misma busqueda que implementa el medico 
        }
    }
}

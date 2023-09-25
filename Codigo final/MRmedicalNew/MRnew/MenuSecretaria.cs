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
    }
}

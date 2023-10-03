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
    public partial class MenuMedico : Form
    {
        public MenuMedico()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //monthCalendar1.Enabled = true; prugentar si funcionaria asi o necesito otra pantalla
        }   //poner pantalla

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AHistorial form = new AHistorial();
            form.Show();
            this.Hide();
        }
    }
}

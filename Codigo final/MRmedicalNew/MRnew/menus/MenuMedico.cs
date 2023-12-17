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
    public partial class MenuMedico : Form
    {
        
        public MenuMedico()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaData form = new AgendaData();
            form.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltroHistorial form = new FiltroHistorial();
            form.Show();
            this.Hide();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //hacer que muestre la palabra historial y al hacer click que me permita escribir y filtrar
        }

        private void hIstorialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FiltroHistorial filtroHistorial = new FiltroHistorial();
            filtroHistorial.Show();
            this.Hide();
        }

        private void butCerrarSesionMed_Click(object sender, EventArgs e)
        {
            LogUsuario usuario = new LogUsuario();
            usuario.Show();
            this.Hide();
        }
    }
}

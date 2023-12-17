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
    public partial class MenuMedico : Form
    {
        public MenuMedico()
        {
            InitializeComponent();
        }

        private void butCerrarSesionMed_Click(object sender, EventArgs e)
        {
            LogUsuario usuario = new LogUsuario();
            usuario.Show();
            this.Hide();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridHistorial filtroHistorial = new DataGridHistorial();
            filtroHistorial.Show();
            this.Hide();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataGridAgenda form = new DataGridAgenda();
            form.Show();
            this.Hide();
        }
    }
}

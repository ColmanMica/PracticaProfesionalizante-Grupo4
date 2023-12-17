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
    public partial class MenuSecretaria : Form
    {
        public MenuSecretaria()
        {
            InitializeComponent();
        }

        private void butCloseSesion_Click(object sender, EventArgs e)
        {
            LogUsuario logUsuario = new LogUsuario();
            logUsuario.Show();
            this.Hide();
        }

        private void stafToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridEspecialidad form = new DataGridEspecialidad();
            form.Show();
            this.Hide();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaMedico form = new AltaMedico();
            form.Show();
            this.Hide();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridPaciente form = new DataGridPaciente();
            form.Show();
            this.Hide();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridHistorial form = new DataGridHistorial();
            form.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridUsuario us = new DataGridUsuario();
            us.Show();
            this.Hide();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAgenda altaAgenda = new AltaAgenda();
            altaAgenda.Show();
            this.Hide();
        }

        private void agregarSecretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaSecretaria altaSecretaria = new AltaSecretaria();
            altaSecretaria.Show();
            this.Hide();
        }

        private void listdoDeMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridMedico form = new DataGridMedico();
            form.Show();
            this.Hide();
        }

        private void listadoDeSecretariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridSecretaria form = new DataGridSecretaria();
            form.Show();
            this.Hide();
        }

        private void abrirAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridAgenda form = new DataGridAgenda();
            form.Show();
            this.Hide();
        }

        private void nuevoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTurno altaTurno = new AltaTurno();
            altaTurno.Show();
            this.Hide();
        }

        private void turnosDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridTurno form = new DataGridTurno();
            form.Show();
            this.Hide();
        }
    }
}

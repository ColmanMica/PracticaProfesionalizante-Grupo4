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
        Principal principal = new Principal();
        BaseDeDatosApp basededatos = new BaseDeDatosApp();
        public NuevoTurno()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void aturno_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();

            turno.pacienteTurno = (Paciente)comboPac.SelectedItem;
            turno.fechaHora = DateTime.Parse(txtDate.Text);
            turno.medicoTurno = (Medico)comboMed.SelectedItem;

            comboMed.DataSource = null;
            comboMed.DisplayMember = "T";
            comboMed.DataSource = basededatos.Turnos;

            MessageBox.Show("Turno agendado.");

            txtDate.Clear();

            //agregar que se pueda ver el id sin que lo ingresen por pantalla
        }

        private void modturno_Click(object sender, EventArgs e)
        {
            /*Turno itemSeleccionado = (Turno)comboMed.SelectedItem;//ver video para que funcione

            Turno turno = new Turno();

            turno.pacienteTurno = (Paciente)comboPac.SelectedItem;
            turno.fechaHora = DateTime.Parse(txtDate.Text);
            turno.medicoTurno = (Medico)comboMed.SelectedItem;

            principal.ModificarTurno(turno, itemSeleccionado);
            comboMed.DataSource = null;
            comboMed.DisplayMember = "T";
            comboMed.DataSource = basededatos.Turnos;*/ //reveer todo porque no va a funcionar 
        }

        private void elimturno_Click(object sender, EventArgs e)
        {
           /* Turno itemSeleccionado = (Turno)comboMed.SelectedItem;

            principal.EliminarTurno(itemSeleccionado);
            comboMed.DataSource = null;
            comboMed.DisplayMember = "T";
            comboMed.DataSource = principal.listaTurnos;*/ //Reveer tambien porque tendria que buscar en la agenda del turno

        }

        private void cancelarT_Click(object sender, EventArgs e)
        {
            MenuSecretaria form = new MenuSecretaria();
            form.Show();
            this.Hide();
        }

        private void combomed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

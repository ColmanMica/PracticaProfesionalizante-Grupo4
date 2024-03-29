﻿using System;
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
            /*NuevoTurno form = new NuevoTurno();
            form.Show();
            this.Hide();*/
        }

        private void stafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AMBMedico form = new AMBMedico();
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
            this.Hide(); // ACA DEVOLVER LA LISTA DE ESPECIALIDADES DE LA BASE DE DATOS Y SEGUN LA ELECCION MOSTRAR LOS MEDICOS QUE HAY
        } // en el load escribir para que me apareza la lista de especialidades y depues hacer un buscador que no no esxixte agrgarla y que eso me lleve al ABMespecialidades

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientesData form = new PacientesData();
            form.Show();
            this.Hide();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltroHistorial form = new FiltroHistorial();
            form.Show();
            this.Hide();
        }

        private void nuevoMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AMBMedico form = new AMBMedico();
            form.Show();
            this.Hide();
        }

        private void nuevoTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosData us = new UsuariosData();
            us.Show();
            this.Hide();
        }

        private void butCloseSesion_Click(object sender, EventArgs e)
        {
            LogUsuario logUsuario = new LogUsuario();
            logUsuario.Show();
            this.Hide();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRmedical
{
    public partial class MenuSecretaria : Form
    {
        public MenuSecretaria()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void turnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTurno form = new AltaTurno();
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

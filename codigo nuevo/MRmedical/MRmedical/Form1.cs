﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRmedical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {













































































































        }

        private void button1_Click(object sender, EventArgs e)
        {
             //if es una secretaria
            {
                MenuSecretaria form = new MenuSecretaria();
                form.Show();
                this.Hide();
            }
             //else 
            {
                MenuMedico form = new MenuMedico();
                form.Show();
                this.Hide();
            }


        }
        
        
    }
    
 }

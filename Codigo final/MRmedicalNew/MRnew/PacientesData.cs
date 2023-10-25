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
    public partial class PacientesData : Form
    {
        Principal principal = new Principal();
        public PacientesData()
        {
            InitializeComponent();
        }

        private void PacientesData_Load(object sender, EventArgs e)
        {
            dataGridPaciente.DataSource = new BindingList<Paciente>(principal.MostrarPacientes()); ;
        }
    }
}

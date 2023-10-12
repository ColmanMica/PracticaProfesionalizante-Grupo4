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
    public partial class ABMespecialidad : Form
    {
        Principal principal = new Principal();
        public ABMespecialidad()
        {
            InitializeComponent();
        }

        private void ABMespecialidad_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = principal.MostrarEspecialidades();


            ((DataGridViewComboBoxColumn)dataGridView1.Columns["CMBProvi"]).DataSource = Provincia.dameListaProv();
        }
    }
}

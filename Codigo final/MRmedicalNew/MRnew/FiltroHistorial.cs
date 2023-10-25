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
    public partial class FiltroHistorial : Form
    {
        Principal principal = new Principal();
        public FiltroHistorial()
        {
            InitializeComponent();
        }

        private void FiltroHistorial_Load(object sender, EventArgs e)
        {
            dataGridHistorial.DataSource = new BindingList<Historial>(principal.MostrarHistoriales()); ;
        }
    }
}

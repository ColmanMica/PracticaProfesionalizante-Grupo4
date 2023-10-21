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
    public partial class AgendaData : Form
    {
        public AgendaData()
        {
            InitializeComponent();
        }

        private void dataGridAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // Para actualizar el dataGrid
            /* BindingSource aBind = new BindingSource();
             aBind.DataSource = // la propiedad de la lista
             DataGridView1.Data = aBind //Modelo.BaseDeDatos.obtenerListaClientes()*/
        }
    }
}

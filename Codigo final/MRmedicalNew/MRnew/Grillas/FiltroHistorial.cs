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

        private void butElimHist_Click(object sender, EventArgs e)
        {
            Historial UserSeleccionado = (Historial)dataGridHistorial.CurrentRow.DataBoundItem;
            var confirmar = MessageBox.Show("¿Seguro que quiere eliminar este historial?", "Historial eliminado", MessageBoxButtons.OKCancel);
            if (confirmar == DialogResult.OK)
            {
                principal.EliminarHistorial(UserSeleccionado);
            }
        }

        private void butModHist_Click(object sender, EventArgs e)
        {
            Historial UserSeleccionado = (Historial)dataGridHistorial.CurrentRow.DataBoundItem;

            principal.ActualizarHistorial(UserSeleccionado);
        }

        private void butVS_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Close();
        }

        private void buthardarHist_Click(object sender, EventArgs e)
        {
            NuevoHistorial nuevoHistorial = new NuevoHistorial();
            nuevoHistorial.Show();
            this.Close();
        }

        private void dataGridHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingSource aBind = new BindingSource();
            aBind.DataSource = principal.MostrarHistoriales();
            dataGridHistorial.DataSource = aBind;
        }

        private void butAtras_Click(object sender, EventArgs e)
        {
            MenuMedico menuMedico = new MenuMedico();
            menuMedico.Show();
            this.Close();
        }
    }
}

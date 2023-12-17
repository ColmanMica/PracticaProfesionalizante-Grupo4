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
    public partial class NuevoHistorial : Form
    {
        Principal principal = new Principal();
        public NuevoHistorial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Historial nuevoHistorial = new Historial();
            nuevoHistorial.nombre = txtnombre.Text;
            nuevoHistorial.apellido = txtapellido.Text;
            nuevoHistorial.dni = int.Parse(txtdni.Text);
            nuevoHistorial.fechaNacimiento = (DateTime)combofechanac.SelectedItem;
            nuevoHistorial.obraSocial = txtobrasoc.Text;
            nuevoHistorial.fechaHora = (DateTime)combofechahr.SelectedItem;

            principal.AltaHistorial(nuevoHistorial);

            MessageBox.Show("El historial fueguardado");
            txtnombre.Clear();
            txtapellido.Clear();
            txtdni.Clear();
            combofechanac.Items.Clear();
            txtobrasoc.Clear();
            combofechahr.Items.Clear();*/
        }

        private void buttAtras_Click(object sender, EventArgs e)
        {
            FiltroHistorial filtroHistorial = new FiltroHistorial();
            filtroHistorial.Show();
            this.Hide();

        }
    }
}

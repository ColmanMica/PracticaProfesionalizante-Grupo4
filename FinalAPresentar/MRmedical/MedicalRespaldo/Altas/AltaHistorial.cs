using BackRespaldo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalRespaldo
{
    public partial class AltaHistorial : Form
    {
        Principal principal = new Principal();
        public AltaHistorial()
        {
            InitializeComponent();
        }

        private void buttAtras_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Historial nuevoHistorial = new Historial();

            nuevoHistorial.obraSocial = txtobrasoc.Text;
            nuevoHistorial.fechaHora = (DateTime)PickerCreacion.Value;

            principal.AltaHistorial(nuevoHistorial);

            MessageBox.Show("El historial fue guardado");

            txtobrasoc.Clear();

        }

        private void AltaHistorial_Load(object sender, EventArgs e)
        {
            var pacientes = principal.MostrarPacientes();
            comboPac.Items.AddRange(pacientes.ToArray());
            comboPac.DisplayMember = "nombre";
           
            

        }

        private void PickerFechanac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void combofechanac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboPac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

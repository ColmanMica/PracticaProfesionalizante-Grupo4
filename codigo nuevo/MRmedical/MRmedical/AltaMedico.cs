using clasessM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRmedical
{
    public partial class AltaMedico : Form
    {
        Principal principal = new Principal();
        public AltaMedico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuSecretaria form = new MenuSecretaria();
            form.Show();
            this.Hide();
        }

        private void aturno_Click(object sender, EventArgs e)
        {
            principal.AltaMedico(int.Parse(textdni.Text), textnombre.Text, textapellido.Text,
                                 DateTime.Parse(textfechanacimiento.Text),(Especialidad)comboespecialidades.SelectedItem);

            listBox2.DataSource = null;
            listBox2.DisplayMember = "Med";
            listBox2.DataSource = principal.ListaMedico;

            MessageBox.Show("Medico agregado.");

            textdni.Clear();
            textnombre.Clear();
            textapellido.Clear();
            textfechanacimiento.Clear();
            //mostrar tambien las especialidades

        }

        private void modturno_Click(object sender, EventArgs e)
        {
            Medico itemSeleccionado = (Medico)listBox2.SelectedItem;//ver video para que funcione

            Medico medico = new Medico();

            medico.dni = int.Parse(textdni.Text);
            medico.nombre = textnombre.Text;
            medico.apellido = textapellido.Text;
            medico.fechaNacimiento = DateTime.Parse(textfechanacimiento.Text); 
            medico.especialidad = (Especialidad)comboespecialidades.SelectedItem;

            /* principal.ModificacionTurno(medico, itemSeleccionado);
             listBox2.DataSource = null;
             listBox2.DisplayMember = "Med";
             listBox2.DataSource = principal.ListaMedico;*/
            //SI AGREGO LA PROPIEDAD DE DIRECCION PUEDO HACER LA MODIFICACION SINO NO HACE FALTA

            principal.BajaMedico(itemSeleccionado);

            listBox2.DataSource = null;
            listBox2.DisplayMember = "Med";
            listBox2.DataSource = principal.ListaMedico;

            MessageBox.Show("Eliminado Correctamente.");
        }

        private void AltaMedico_Load(object sender, EventArgs e)
        {

        }

        private void textdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboespecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            principal.MostrarEspecialidades();
        }
    }
    
}

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
    public partial class AltaMedico : Form
    {
        Principal principal = new Principal();
        public AltaMedico()
        {
            InitializeComponent();
        }

        private void amedico_Click(object sender, EventArgs e)
        {
            Medico nuevoMedico = new Medico();
            nuevoMedico.dni = int.Parse(txtdni.Text);
            nuevoMedico.nombre = textname.Text;
            nuevoMedico.apellido = txtapell.Text;
            nuevoMedico.fechaNacimiento = DateTime.Parse(txtdate.Text);
            nuevoMedico.especialidad = (Especialidad)comboespec.SelectedItem;
           
            principal.AltaMedico(nuevoMedico);

            /*listBox2.DataSource = null;
            listBox2.DisplayMember = "Med";
            listBox2.DataSource = principal.ListaMedico;*/ //aca creo que se suma al dataGriv

            MessageBox.Show("Medico agregado.");

            /*textdni.Clear();
            textnombre.Clear();
            textapellido.Clear();
            textfechanacimiento.Clear();
            //mostrar tambien las especialidades*/ // MODIFICAR SEGUN LOS CAMBIOS EN PANTALLA
        }

        private void modmed_Click(object sender, EventArgs e)
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

            principal.EliminarMedico(itemSeleccionado);
        }

        private void elimedico_Click(object sender, EventArgs e)
        {

        }

        private void comboespec_SelectedIndexChanged(object sender, EventArgs e)
        {
            principal.MostrarEspecialidades();
        }

        private void cancelarM_Click(object sender, EventArgs e)
        {
            MenuSecretaria form = new MenuSecretaria();
            form.Show();
            this.Hide();
        }
    }
}

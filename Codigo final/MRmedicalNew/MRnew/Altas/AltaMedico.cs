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

        private void butAgregar_Click(object sender, EventArgs e)
        {
            var nuevoMedico = new Medico();
            nuevoMedico.matriculaMedico = txtMatricula.Text;
            nuevoMedico.dni = int.Parse(txtdni.Text);
            nuevoMedico.nombre = txtnombre.Text;
            nuevoMedico.apellido = txtapellido.Text;
            nuevoMedico.direccion = txtdirecc.Text;
            nuevoMedico.fechaNacimiento = (DateTime)dateTimePicker1.Value;
            nuevoMedico.especialidad = (Especialidad)comboEspecialidades.SelectedItem;

            principal.AltaMedico(nuevoMedico);

            MessageBox.Show("El medico fue guardado");

            txtMatricula.Clear();
            txtdni.Clear();
            txtnombre.Clear();
            txtdirecc.Clear();
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butAtras_Click(object sender, EventArgs e)
        {
            MenuSecretaria menuSecretaria = new MenuSecretaria();
            menuSecretaria.Show();
            this.Hide();
        }

        private void AltaMedico_Load(object sender, EventArgs e)
        {
            var especialidades = principal.MostrarEspecialidades();
            comboEspecialidades.Items.AddRange(especialidades.ToArray());
            comboEspecialidades.DisplayMember = "nombre";
        }
    }
}

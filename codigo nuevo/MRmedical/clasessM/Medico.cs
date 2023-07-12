using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace clasessM
{
    public class Medico : Persona
    {
        public string especialidad { get; set; }
        public Usuario usuarioMedico { get; set; }
        public string Med
        {
            get { return "DNI: " + dni + ", Nombre: " + nombre + ", Apelido: " + apellido + ", ,Especialidad: " + especialidad + ", Fecha de Nacimiento: " + fechaNacimiento; }
        }
    }




























}


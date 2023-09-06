using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Usuario : Persona
    {
        public string idUsuario { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }
        public string tipo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasessM
{
    public class Medico : Persona
    {
        public string especialidad { get; set; }
        public Usuario usuarioMedico { get; set; }
    }
}


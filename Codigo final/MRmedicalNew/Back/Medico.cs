using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Medico:Persona
    {
        public Especialidad especialidad { get; set; }
        public Usuario usuarioMedico { get; set; }
    }
}

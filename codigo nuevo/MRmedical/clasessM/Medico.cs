using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasessM
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public Usuario Usuario_Medico { get; set; }
    }
}


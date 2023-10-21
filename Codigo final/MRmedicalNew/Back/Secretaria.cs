using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Secretaria:Persona
    {
        public int id { get; set; }
        public int idSecretaria { get; set;  }
        public int numerolegajo { get; set; }
        public Usuario usuarioSecretaria { get; set; }
    }
}

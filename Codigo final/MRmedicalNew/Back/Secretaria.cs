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
        [Key]
        public int numerolegajo { get; set; }
        public Usuario usuarioSecretaria { get; set; }
    }
}

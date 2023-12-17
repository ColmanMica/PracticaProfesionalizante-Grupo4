using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Paciente : Persona
    {
        public int idPaciente { get; set; }
        public bool vacunasAlDia { get; set; }
    }
}


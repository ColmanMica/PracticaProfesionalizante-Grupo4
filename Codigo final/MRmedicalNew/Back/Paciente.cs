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
        public int id { get; set; }
        public int idpaciente {  get; set; }
        public double vacunasAlDia { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackRespaldo
{
    public class Paciente : Persona
    {
        public int id { get; set; }
         public bool vacunasAlDia { get; set; }

        public override string ToString()
        {
            return nombre;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasessM
{
    public class Turno
    {
        public int id_Turno {  get; set; }
        public DateTime FechayHora { get; set; }
        public string Medico { get; set; }
    }
}        // metodo para busar el id del paciente, si no se encuentra redireccionar
         // dar de alta un nuevo paciente

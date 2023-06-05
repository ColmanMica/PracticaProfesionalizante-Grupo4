using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasessM
{
    public class Turno
    {
        public int idTurno {  get; set; }
        public DateTime fechaHora { get; set; }
        public string medico { get; set; }
    }
}        // metodo para busar el id del paciente, si no se encuentra redireccionar
         // dar de alta un nuevo paciente

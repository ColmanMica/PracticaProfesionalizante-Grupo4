using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackRespaldo  
{
    public class Turno
    {
        public int id { get; set; }
        
        public DateTime fechaHora { get; set; }
        public Medico medicoTurno { get; set; } //era necesario que que el tipo sea una clase?
        public Paciente pacienteTurno { get; set; }
    }
}// metodo para busar el id del paciente, si no se encuentra redireccionar
 // dar de alta un nuevo paciente /pensar es hacer el if dentro del metodo de alta

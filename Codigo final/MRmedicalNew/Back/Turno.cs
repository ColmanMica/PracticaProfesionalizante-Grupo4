using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Turno
    {
        public int idTurno { get; set; }
        public DateTime fechaHora { get; set; }
        public Medico medicoTurno { get; set; } //era necesario que que el tipo sea una clase?
        public Paciente pacienteTurno { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Agenda
    {
        public string paciente { get; set; }
        public DateTime fechaHora { get; set; }
        public Medico medicoAgenda { get; set; }
    }
}

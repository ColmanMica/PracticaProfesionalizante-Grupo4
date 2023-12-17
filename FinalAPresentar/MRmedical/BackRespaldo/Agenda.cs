using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackRespaldo
{
    public class Agenda
    {
        public int id { get; set; }
        public string paciente { get; set; }
        public DateTime fechaHora { get; set; }
        public Medico medicoAgenda { get; set; }

        /*   
        public string paciente { get; set; }
        public DateTime fechaHora { get; set; }
        public Medico medicoAgenda { get; set; }*/

    }
}

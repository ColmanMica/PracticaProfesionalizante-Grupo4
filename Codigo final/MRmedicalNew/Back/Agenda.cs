using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Agenda
    {
        public int Id {  get; set; }    
        public int idAgenda { get; set; }
        public string paciente { get; set; }
        public DateTime fechaHora { get; set; }
        public Medico medicoAgenda { get; set; }
    }
}

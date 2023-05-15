using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaClases
{
    public class Historial : Paciente
    {
        public string Paciente { get; set; }
        public string Medico { get; set; }

        public string Historial { get; set; }
    }
}

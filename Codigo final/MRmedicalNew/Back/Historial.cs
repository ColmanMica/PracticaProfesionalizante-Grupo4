using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Historial
    {
        [Key]
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime fechaHora { get; set; }
        public string obraSocial { get; set; }
    }
}

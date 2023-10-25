﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Collections.Specialized.BitVector32;

namespace Back
{
    public class Medico:Persona
    {
        //public int id { get; set; }
        public string matriculaMedico { get; set; }
        public Especialidad especialidad { get; set; }
        public Usuario usuarioMedico { get; set; }
       /* public string correo { get; set; }
        public string contrasenia { get; set; }*/


        List<Especialidad> especialidadList { get; set; }//doble enganche
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Usuario
    { 
       public int id { get; set; }  
        //public string idUsuario { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }
        public string tipo { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Especialidad
    {
        [Key]
        public int idEspecialidad { get; set; }
        public string nombre { get; set; }
    }
}

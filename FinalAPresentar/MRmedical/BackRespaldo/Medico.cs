using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Collections.Specialized.BitVector32;

namespace BackRespaldo
{
    public class Medico:Persona
    {
        public int id { get; set; }
        public string matriculaMedico { get; set; }
        public Especialidad especialidad { get; set; }
        public Usuario? usuarioMedico { get; set; }
        public override string ToString()
        {
            return nombre;
        }

        /*public static Medico buscarMedico(Usuario paramusuario)
        {
            Principal mivarprin = new Principal();
            Medico medicoEncontrado = mivarprin.MostrarMedicos().FirstOrDefault(m => m.usuarioMedico == paramusuario);
            medicoEncontrado.usuarioMedico = paramusuario;
            return medicoEncontrado;
        
        
        } */

    }


       
}


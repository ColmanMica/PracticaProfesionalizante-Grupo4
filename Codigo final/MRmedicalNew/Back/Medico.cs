using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Collections.Specialized.BitVector32;

namespace Back
{
    public class Medico : Persona
    {
       
        public int idMedico { get; set; }
        public string matriculaMedico { get; set; }
        public Especialidad especialidad { get; set; }
        public Usuario usuarioMedico { get; set; }
        /*public Medico BuscarMedico(Usuario paramusuario)
        {

            Principal mivarprin = new Principal();
            mivarprin.MostrarMedicos().First<Medico>(m => m.usuarioMedico == paramusuario);

            if (usuarioMedico == paramusuario) ;
            {

            }
        }*/
    }
}

        
            /*Principal principal = new Principal();
            Medico medicoAutenticado = principal.MostrarMedicos().FirstOrDefault(m => m.usuarioMedico == paramusuario);

            if (medicoAutenticado != null)
            {
               return medicoAutenticado.usuarioMedico;*/
            
        



        /*if (paramusuario != null)
        {
            // El médico ha sido encontrado
            return medicoBuscado; //TERMINATR SINO USAR EL DE GABI DE LA PPT
        }
        else
        {
            // El médico no ha sido encontrado
            return null; // O puedes manejar de otra manera, como lanzar una excepción
        }
        public Medico BuscarMedico(Usuario paramusuario)
        {
            Principal principal =new Principal();
            Medico medicoAutenticado = principal.MostrarMedicos().First(m => m.usuarioMedico == paramusuario);

     // busdca en google como usare el fisrt para buscar medico.usuario = al param
      // entones al tener el usuario lamas a este ,ediotodo pasanedo el usuario y te a va a regresar e; ,edoico aue coresc[pasodfaskp*/
    





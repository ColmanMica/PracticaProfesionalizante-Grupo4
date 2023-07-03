using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace clasessM
{
    public class Class1
    {
        List<Paciente>ListaPaciente = new List<Paciente>();
        List<Medico>ListaMedico = new List<Medico>();
        List<Historial>ListaHistorial = new List<Historial>();
        List<Turno>ListaTurno = new List<Turno>();


        public void AltaPaciente(int dni, string nombre, string apellido, DateTime fechanac)
        {
            Paciente Nuevopaciente = new Paciente();
            Nuevopaciente.dni = dni;
            Nuevopaciente.nombre = nombre;
            Nuevopaciente.apellido = apellido;
            Nuevopaciente.fechaNacimiento = fechanac;
            ListaPaciente.Add(Nuevopaciente);
        }

        public void AltaMedico(int dni, string nombre, string apellido, DateTime fechanac, string especialidad)
        {
            Medico Nuevomedico = new Medico();
            Nuevomedico.dni = dni;
            Nuevomedico.nombre = nombre;
            Nuevomedico.apellido = apellido;
            Nuevomedico.fechaNacimiento = fechanac;
            Nuevomedico.especialidad = especialidad;
            ListaMedico.Add(Nuevomedico);
        }
        

        public void AltaHistorial(int dni, string nombre,string apellido, DateTime fechayhora, string obrasocial)
        {
            Historial Nuevohistorial = new Historial();

            Nuevohistorial.dni = dni; // esto se cambia cuando agrego el front
            Nuevohistorial.nombre = nombre;
            Nuevohistorial.apellido = apellido;
            Nuevohistorial.fechaHora = fechayhora;
            Nuevohistorial.obraSocial = obrasocial;
            ListaHistorial.Add(Nuevohistorial);
        }
         public void ModificacionHitorial(string obrasocial) 
        {
            Historial Nuevohistorial = new Historial();
            var historialBuscado = ListaHistorial.Find(x => x.obraSocial == obrasocial);

            Nuevohistorial.obraSocial = obrasocial;

            Nuevohistorial.dni = historialBuscado.dni;
            Nuevohistorial.nombre = historialBuscado.nombre;
            Nuevohistorial.apellido = historialBuscado.apellido;
            Nuevohistorial.fechaHora = historialBuscado.fechaHora;

            ListaHistorial.Remove(historialBuscado);
            ListaHistorial.Add(Nuevohistorial);
        }
        public void AltaTurno( DateTime fechaHora, Medico medicoTurno, Paciente pacienteTurno)
        {
            Turno Nuevoturno = new Turno();
            var contador = ListaTurno.Count() + 1;

            Nuevoturno.idTurno = contador; 
            Nuevoturno.fechaHora = fechaHora;
            Nuevoturno.medicoTurno = medicoTurno;
            Nuevoturno.pacienteTurno = pacienteTurno;
            ListaTurno.Add(Nuevoturno);
        }
    }
}

    


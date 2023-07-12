using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace clasessM
{
    public class Principal
    {
        public List<Paciente> ListaPaciente = new List<Paciente>();
        public List<Medico> ListaMedico = new List<Medico>();
        public List<Historial> ListaHistorial = new List<Historial>();
        public List<Turno> ListaTurno = new List<Turno>();


        public void AltaPaciente(int dni, string nombre, string apellido, DateTime fechanac, double vacunasAlDia)
        {
            Paciente Nuevopaciente = new Paciente();
            Nuevopaciente.dni = dni;
            Nuevopaciente.nombre = nombre;
            Nuevopaciente.apellido = apellido;
            Nuevopaciente.fechaNacimiento = fechanac;
            Nuevopaciente.vacunasAlDia = vacunasAlDia;
            ListaPaciente.Add(Nuevopaciente);
        }
        public void ModificacionPaciente(double vacunasAlDia)
        {
            Paciente Nuevopaciente = new Paciente();
            var pacienteBuscado = ListaPaciente.Find(x => x.vacunasAlDia == vacunasAlDia);

            Nuevopaciente.vacunasAlDia = vacunasAlDia;

            Nuevopaciente.dni = pacienteBuscado.dni;
            Nuevopaciente.nombre = pacienteBuscado.nombre;
            Nuevopaciente.apellido = pacienteBuscado.apellido;
            Nuevopaciente.fechaNacimiento = pacienteBuscado.fechaNacimiento;
            
            ListaPaciente.Remove(pacienteBuscado);
            ListaPaciente.Add(Nuevopaciente);

        }
        public void BajaPaciente(Paciente PacienteParametro)
        {
            ListaPaciente.Remove(PacienteParametro);
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

        public void BajaMedico(Medico MedicoParametro)
        {
            ListaMedico.Remove(MedicoParametro);
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
        public void BajaHistorial(Historial HistorialParametro)
        {
            ListaHistorial.Remove(HistorialParametro);
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
        public void ModificacionTurno(Turno NuevoTurno, Turno eliminarTurno)
        {
            Turno turnoModificado = new Turno();
           
            turnoModificado.idTurno = NuevoTurno.idTurno;
            turnoModificado.medicoTurno = NuevoTurno.medicoTurno;
            turnoModificado.pacienteTurno = NuevoTurno.pacienteTurno;


            ListaTurno.Remove(eliminarTurno);
            ListaTurno.Add(NuevoTurno);
        }
        public void BajaTurno(Turno TurnoParametro)
        {
            ListaTurno.Remove(TurnoParametro);
        }
    }
}

    


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
        public List<Especialidad> ListaEspecialidades = new List<Especialidad>();

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
        public void ModificacionPaciente(int dni)
        {
            Paciente pacienteModificado = new Paciente();
            var pacienteBuscado = ListaPaciente.Find(x => x.dni == dni);

            pacienteModificado.dni = dni;
            pacienteModificado.nombre = pacienteBuscado.nombre;
            pacienteModificado.apellido = pacienteBuscado.apellido;
            pacienteModificado.fechaNacimiento = pacienteBuscado.fechaNacimiento;
            pacienteModificado.vacunasAlDia = pacienteBuscado.vacunasAlDia;

            ListaPaciente.Remove(pacienteBuscado);
            ListaPaciente.Add(pacienteModificado);

        }
        public void BajaPaciente(Paciente PacienteParametro)
        {
            ListaPaciente.Remove(PacienteParametro);
        }

        public void AltaMedico(int dni, string nombre, string apellido, DateTime fechanac, Especialidad especialidad)
        {
            Medico Nuevomedico = new Medico();
            Nuevomedico.dni = dni;
            Nuevomedico.nombre = nombre;
            Nuevomedico.apellido = apellido;
            Nuevomedico.fechaNacimiento = fechanac;
            Nuevomedico.especialidad = especialidad;
            ListaMedico.Add(Nuevomedico);
        }

        public void ModificacionMedico(int dni)
        {
            Medico medicoModificado = new Medico();
            var medicoBuscado = ListaMedico.Find(x => x.dni == dni);

            medicoModificado.dni = dni;
            medicoModificado.nombre = medicoBuscado.nombre;
            medicoModificado.apellido = medicoBuscado.apellido;
            medicoModificado.fechaNacimiento = medicoBuscado.fechaNacimiento;
            medicoModificado.especialidad = medicoBuscado.especialidad;

            ListaMedico.Remove(medicoBuscado);
            ListaMedico.Add(medicoModificado);
        }


        public void BajaMedico(Medico MedicoParametro)
        {
            ListaMedico.Remove(MedicoParametro);
        }


        public void AltaHistorial(int dni, string nombre, string apellido, DateTime fechayhora, string obrasocial)
        {
            Historial Nuevohistorial = new Historial();

            Nuevohistorial.dni = dni; // esto se cambia cuando agrego el front
            Nuevohistorial.nombre = nombre;
            Nuevohistorial.apellido = apellido;
            Nuevohistorial.fechaHora = fechayhora;
            Nuevohistorial.obraSocial = obrasocial;
            ListaHistorial.Add(Nuevohistorial);
        }
        public void ModificacionHitorial(int dni)
        {
            Historial historialModificado = new Historial();
            var historialBuscado = ListaHistorial.Find(x => x.dni == dni);

            historialModificado.dni = dni;
            historialModificado.nombre = historialBuscado.nombre;
            historialModificado.apellido = historialBuscado.apellido;
            historialModificado.fechaHora = historialBuscado.fechaHora;
            historialModificado.obraSocial = historialBuscado.obraSocial;

            ListaHistorial.Remove(historialBuscado);
            ListaHistorial.Add(historialModificado);
        }
        public void BajaHistorial(Historial HistorialParametro)
        {
            ListaHistorial.Remove(HistorialParametro);
        }
        public void AltaTurno(DateTime fechaHora, Medico medicoTurno, Paciente pacienteTurno)
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

        public List<Especialidad> MostrarEspecialidades() //que hago con esto?
        {
            return ListaEspecialidades;
        }
        /*public bool ValidarUsuario(string correo, string contrasenia)
        {
            Usuario usuario = new Usuario();
            if (usuario.correo == correo)
            {
                if (usuario.contrasenia == contrasenia)
                {
                    return true;
                }
                else
                {
                    return false;//Contrasenia invalida
                }
            }
            return false;//Usuario invalido*/
             


        }
        //metodo de busqueda de medicos porque la secretaria primerio selecciona la especialidad
        //y despues el medico que tenga lugar o el que el paciengte elija 
    }





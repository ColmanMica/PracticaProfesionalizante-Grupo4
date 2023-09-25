using System.ComponentModel.DataAnnotations;

namespace Back
{
    public class Principal
    {
        BaseDeDatosApp context = new BaseDeDatosApp();


        public void AltaPaciente(Paciente paciente)
        {
            using (var context = new BaseDeDatosApp())
            {
                var nuevoPaciente = new Paciente { dni = paciente.dni, nombre = paciente.nombre, apellido = paciente.apellido, fechaNacimiento = paciente.fechaNacimiento, vacunasAlDia = paciente.vacunasAlDia, direccion = paciente.direccion };
                context.Pacientes.Add(nuevoPaciente);
                context.SaveChanges();
            }

        }

        public void ActualizarPaciente(Paciente paciente)
        {
            using (var context = new BaseDeDatosApp())
            {
                var pacienteAActualizar = context.Pacientes.Find(paciente.dni);
                if (pacienteAActualizar != null)
                {
                    pacienteAActualizar.dni = paciente.dni;
                    pacienteAActualizar.nombre = paciente.nombre;
                    pacienteAActualizar.apellido = paciente.apellido;
                    pacienteAActualizar.vacunasAlDia = paciente.vacunasAlDia;
                    pacienteAActualizar.direccion = paciente.direccion;
                    context.SaveChanges();
                }

            }

        }

        public void EliminarPaciente(Paciente paciente)
        {
            using (var context = new BaseDeDatosApp())
            {
                var pacienteABorrar = context.Pacientes.Find(paciente.dni);
                if (pacienteABorrar != null)
                {
                    context.Pacientes.Remove(pacienteABorrar);
                    context.SaveChanges();
                }
            }
        }

        public void AltaMedico(Medico medico)
        {
            using (var context = new BaseDeDatosApp())
            {
                var nuevoMedico = new Medico { dni = medico.dni,matriculaMedico = medico.matriculaMedico, nombre = medico.nombre, apellido = medico.apellido, fechaNacimiento = medico.fechaNacimiento, especialidad = medico.especialidad, direccion = medico.direccion };
                context.Medicos.Add(nuevoMedico);
                context.SaveChanges();
            }
        }

        public void ActualizarMedico(Medico medico, Especialidad especialidad)
        {
            using (var context = new BaseDeDatosApp())
            {
                var medicoAActualizar = context.Medicos.Find(medico.matriculaMedico);
                if (medicoAActualizar != null)
                {
                    medicoAActualizar.dni = medico.dni;
                    medicoAActualizar.nombre = medico.nombre;
                    medicoAActualizar.apellido = medico.apellido;
                    medicoAActualizar.direccion = medico.direccion;

                    medicoAActualizar.especialidad.nombre = especialidad.nombre;
                    // que hago con la especialidad
                    context.SaveChanges();
                }

            }

        }

        public void EliminarMedico(Medico medico)
        {
            using (var context = new BaseDeDatosApp())
            {
                var medicoABorrar = context.Medicos.Find(medico.matriculaMedico);
                if (medicoABorrar != null)
                {
                    context.Medicos.Remove(medicoABorrar);
                    context.SaveChanges();
                }
            }
        }

        public void AltaHistorial(Historial historial)
        {
            using (var context = new BaseDeDatosApp())
            {
                var nuevoHistorial = new Historial { dni = historial.dni, nombre = historial.nombre, apellido = historial.apellido, fechaNacimiento = historial.fechaNacimiento, fechaHora = historial.fechaHora, obraSocial = historial.obraSocial };
                context.Historiales.Add(nuevoHistorial);
                context.SaveChanges();
            }
        }

        public void ActualizarHistorial(Historial historial)
        {
            using (var context = new BaseDeDatosApp())
            {
                var historialAActualizar = context.Historiales.Find(historial.apellido, historial.nombre);
                if (historialAActualizar != null)
                {
                    historialAActualizar.dni = historial.dni;
                    historialAActualizar.nombre = historial.nombre;
                    historialAActualizar.apellido = historial.apellido;
                    historialAActualizar.fechaHora = historial.fechaHora;
                    historialAActualizar.obraSocial = historial.obraSocial;
                    context.SaveChanges();
                }

            }
        }
        public void EliminarHistoria(Historial historial)
        {
            using (var context = new BaseDeDatosApp())
            {
                var historialABorrar = context.Historiales.Find(historial.apellido, historial.nombre);
                if (historialABorrar != null)
                {
                    context.Historiales.Remove(historialABorrar);
                    context.SaveChanges();
                }
            }
        }
        public void Altaturno(Turno turno)
        {
            using (var context = new BaseDeDatosApp())
            {
                //hacer en la base el id autonumerico
                var nuevoTurno = new Turno { fechaHora = turno.fechaHora, medicoTurno = turno.medicoTurno, pacienteTurno = turno.pacienteTurno };
                context.Turnos.Add(nuevoTurno);
                context.SaveChanges();
            }
        }
        public void ModificarTurno(Turno turno)
        {
            using (var context = new BaseDeDatosApp())
            {
                var TurnoAModificar = context.Turnos.Find(turno.idTurno);
                if (TurnoAModificar != null)
                {
                    TurnoAModificar.fechaHora = turno.fechaHora;
                    TurnoAModificar.medicoTurno = turno.medicoTurno;
                    TurnoAModificar.medicoTurno = turno.medicoTurno;
                    context.SaveChanges();
                }

            }
        }
        public void EliminarTurno(Turno turno)
        {
            using (var context = new BaseDeDatosApp())
            {
                var turnoABorrar = context.Turnos.Find(turno.idTurno);
                if (turnoABorrar != null)
                {
                    context.Turnos.Remove(turnoABorrar);
                    context.SaveChanges();
                }//metodo de busqueda de medicos porque la secretaria primerio selecciona la especialidad
                 //y despues el medico que tenga lugar o el que el paciente elija 
            }
        }

        public void MostrarEspecialidades() //que hago con esto?
        {
            return;//lista de especialidades
        }


    }
}
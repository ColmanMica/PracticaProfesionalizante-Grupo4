using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;



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
                    if (pacienteAActualizar.nombre != paciente.nombre)
                    {
                        paciente.nombre = pacienteAActualizar.nombre;
                    }
                    if (pacienteAActualizar.apellido != paciente.apellido)
                    {
                        paciente.apellido = pacienteAActualizar.apellido;
                    }
                    if (pacienteAActualizar.vacunasAlDia != paciente.vacunasAlDia)
                    {
                        paciente.vacunasAlDia = pacienteAActualizar.vacunasAlDia;
                    }
                    if (pacienteAActualizar.direccion != paciente.direccion)
                    {
                        paciente.direccion = pacienteAActualizar.direccion;
                    }

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
                var nuevoMedico = new Medico { dni = medico.dni, matriculaMedico = medico.matriculaMedico, nombre = medico.nombre, apellido = medico.apellido, fechaNacimiento = medico.fechaNacimiento, especialidad = medico.especialidad, direccion = medico.direccion };
                context.Medicos.Add(nuevoMedico);
                
                context.SaveChanges();
            }
        }

        public void ActualizarMedico(Medico medico)
        {
            using (var context = new BaseDeDatosApp())
            {
                var medicoAActualizar = context.Medicos.Find(medico.matriculaMedico);
                if (medicoAActualizar != null)
                {
                    if (medicoAActualizar.nombre != medico.nombre)
                    {
                        medico.nombre = medico.nombre;
                    }
                    if (medicoAActualizar.apellido != medico.apellido)
                    {
                        medicoAActualizar.apellido = medico.apellido;
                    }
                    if (medicoAActualizar.direccion != medico.direccion)
                    {
                        medicoAActualizar.direccion = medico.direccion;
                    }

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
                var nuevoHistorial = new Historial { paciente = historial.paciente, fechaHora = historial.fechaHora, obraSocial = historial.obraSocial };
                context.Historiales.Add(nuevoHistorial);
                context.SaveChanges();
            }
        }

        public void ActualizarHistorial(Historial historial)
        {
            using (var context = new BaseDeDatosApp())
            {
                var historialAActualizar = context.Historiales.Find(historial.paciente);
                if (historialAActualizar != null)
                {
                    if (historialAActualizar.paciente!= historial.paciente)
                    {
                        historialAActualizar.paciente = historial.paciente;
                    }
                    if (historialAActualizar.fechaHora != historial.fechaHora)
                    {
                        historialAActualizar.fechaHora = historial.fechaHora;
                    }
                    if (historialAActualizar.obraSocial != historial.obraSocial)
                    {
                        historialAActualizar.obraSocial = historial.obraSocial;
                    }

                    context.SaveChanges();
                }

            }
        }
        public void EliminarHistorial(Historial historial)
        {
            using (var context = new BaseDeDatosApp())
            {
                var historialABorrar = context.Historiales.Find(historial.paciente);
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

                var nuevoTurno = new Turno { fechaHora = turno.fechaHora, medicoTurno = turno.medicoTurno, pacienteTurno = turno.pacienteTurno };
                context.Turnos.Add(nuevoTurno);
                context.SaveChanges();
            }
        }
        public void ModificarTurno(Turno turno)
        {
            using (var context = new BaseDeDatosApp())
            {
                var TurnoAModificar = context.Turnos.Find(turno.id);
                if (TurnoAModificar != null)
                {
                    if (TurnoAModificar.fechaHora != turno.fechaHora)
                    {
                        TurnoAModificar.fechaHora = turno.fechaHora;
                    }
                    if (TurnoAModificar.medicoTurno != turno.medicoTurno)
                    {
                        TurnoAModificar.medicoTurno = turno.medicoTurno;
                    }
                    if (TurnoAModificar.pacienteTurno != turno.pacienteTurno)
                    {
                        TurnoAModificar.pacienteTurno = turno.pacienteTurno;
                    }

                    context.SaveChanges();
                }

            }
        }
        public void EliminarTurno(Turno turno)
        {
            using (var context = new BaseDeDatosApp())
            {
                var turnoABorrar = context.Turnos.Find(turno.id);
                if (turnoABorrar != null)
                {
                    context.Turnos.Remove(turnoABorrar);

                }
                context.SaveChanges();
            }

        }
        public void AltaUsuario(string correo, string contrasenia, string tipo)
        {
            using (var context = new BaseDeDatosApp())
            {

                var nuevoUsuario = new Usuario { correo = correo, contrasenia = contrasenia, tipo = tipo };
                
                context.Usuarios.Add(nuevoUsuario);
                context.SaveChanges();
            }
        }
        public void ModificarUsuario(Usuario usuario)
        {
            using (var context = new BaseDeDatosApp())
            {
                var usuarioAModificar = context.Usuarios.Find(usuario.id);
                if (usuarioAModificar != null)
                {
                    if (usuarioAModificar.correo != usuario.correo)
                    {
                        usuarioAModificar.correo = usuario.correo;
                    }
                    if (usuarioAModificar.contrasenia != usuario.contrasenia)
                    {
                        usuarioAModificar.contrasenia = usuario.contrasenia;
                    }
                    if (usuarioAModificar.tipo != usuario.tipo)
                    {
                        usuarioAModificar.tipo = usuario.tipo;
                    }
                }
                context.SaveChanges();
            }
        }
        public void EliminarUsuario(Usuario usuario)
        {
            using (var context = new BaseDeDatosApp())
            {
                var usuarioABorrar = context.Usuarios.Find(usuario.id);
                if (usuarioABorrar != null)
                {
                    context.Usuarios.Remove(usuarioABorrar);

                }
                context.SaveChanges();
            }
        }


        public void CrearAgenda(Paciente paciente, Medico medico, Turno fechadelturno)
        {
            using (var context = new BaseDeDatosApp())
            {

                var nuevaAgenda = new Agenda { paciente = paciente.nombre, medicoAgenda = medico, fechaHora = fechadelturno.fechaHora };
                context.Agendas.Add(nuevaAgenda);
                context.SaveChanges();
            }
        }
        public void ModificarAgenda(Agenda agenda)
        {
            using (var context = new BaseDeDatosApp())
            {
                var agendaAModificar = context.Agendas.Find(agenda.id);
                if (agendaAModificar != null)
                {
                    if (agendaAModificar.paciente != agenda.paciente)
                    {
                        agendaAModificar.paciente = agenda.paciente;
                    }
                    if (agendaAModificar.medicoAgenda != agenda.medicoAgenda)
                    {
                        agendaAModificar.medicoAgenda = agenda.medicoAgenda;
                    }
                    if (agendaAModificar.fechaHora != agenda.fechaHora)
                    {
                        agendaAModificar.fechaHora = agenda.fechaHora;
                    }
                }
                context.SaveChanges();
            }
        }
        public void EliminarAgenda(Agenda agenda)
        {
            using (var context = new BaseDeDatosApp())
            {
                var agendaABorrar = context.Agendas.Find(agenda.id);
                if (agendaABorrar != null)
                {
                    context.Agendas.Remove(agendaABorrar);

                }
                context.SaveChanges();
            }
        }
        public void AltaSecretaria(Secretaria secretaria)
        {
            using (var context = new BaseDeDatosApp())
            {

                var nuevaSecretaria = new Secretaria { numerolegajo = secretaria.numerolegajo, dni = secretaria.dni, nombre = secretaria.nombre, apellido = secretaria.apellido, fechaNacimiento = secretaria.fechaNacimiento, direccion = secretaria.direccion };
                context.Secretarias.Add(nuevaSecretaria);
                context.SaveChanges();
            }
        }
        public void ModificarSecretaria(Secretaria secretaria)
        {
            using (var context = new BaseDeDatosApp())
            {
                var secretariaAModificar = context.Secretarias.Find(secretaria.idSecretaria);
                if (secretariaAModificar != null)
                {
                    if (secretariaAModificar.numerolegajo != secretaria.numerolegajo)
                    {
                        secretariaAModificar.numerolegajo = secretaria.numerolegajo;
                    }
                    if (secretariaAModificar.nombre != secretaria.nombre)
                    {
                        secretariaAModificar.nombre = secretaria.nombre;
                    }
                    if (secretariaAModificar.apellido != secretaria.apellido)
                    {
                        secretariaAModificar.apellido = secretaria.apellido;
                    }
                    if (secretariaAModificar.direccion != secretaria.direccion)
                    {
                        secretariaAModificar.direccion = secretaria.direccion;
                    }
                }
                context.SaveChanges();
            }
        }
        public void EliminarSecretaria(Secretaria secretaria)
        {
            using (var context = new BaseDeDatosApp())
            {
                var secretariaABorrar = context.Secretarias.Find(secretaria.id);
                if (secretariaABorrar != null)
                {
                    context.Secretarias.Remove(secretariaABorrar);

                }
                context.SaveChanges();
            }
        }




        // LISTAS DE ACCESO A LA BASE DE DATOS


        public List<Especialidad> MostrarEspecialidades()
        {
            var ListaEspecialidad = context.Especialidades.ToList();

            return ListaEspecialidad;
        }

        public List<Usuario> MostrarUsuarios()
        {
            var ListaUsuarios = context.Usuarios.ToList();

            return ListaUsuarios;
        }
        public List<Agenda> MostrarAgenda()
        {
            var ListaAgenda = context.Agendas.ToList();

            return ListaAgenda;
        }
        public List<Historial> MostrarHistoriales()
        {
            var ListaHistoriales = context.Historiales.ToList();

            return ListaHistoriales;
        }
        public List<Turno> MostrarTurnos()
        {
            var ListaTurnos = context.Turnos.ToList();

            return ListaTurnos;
        }

        public List<Paciente> MostrarPacientes()
        {
            var ListaPacientes = context.Pacientes.ToList();

            return ListaPacientes;
        }
        public List<Medico> MostrarMedicos()
        {
            var ListaMedicos = context.Medicos.ToList();

            return ListaMedicos;
        }
        public List<Secretaria> MostrarSecretarias()
        {
            var ListaSecretarias = context.Secretarias.ToList();

            return ListaSecretarias;
        }

    }
}



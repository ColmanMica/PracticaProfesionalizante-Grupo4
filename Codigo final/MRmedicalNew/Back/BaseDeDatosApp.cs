using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class BaseDeDatosApp : DbContext
    {
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Historial> Historiales { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Secretaria> Secretarias{ get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("server=ROCIORELLANO;database=BaseTP;trusted_connection=true;encrypt=False");
        }

        
    }
}

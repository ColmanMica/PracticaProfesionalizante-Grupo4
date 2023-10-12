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
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Secretaria> Secretarias { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Persona>()
             .HasOne(s => s.)
            .WithMany()
            .HasForeignKey(e => e.Message_Id)
        .WillCascadeOnDelete(false);
        }
        */
            //protected override void OnModelCreating(DbModelBuilder modelBuilder)
            //{
            //   modelBuilder.Entity<ClaseA>()
            //      .HasOptional(a => a.ClaseB)
            //    .WithMany()
            //  .HasForeignKey(a => a.ClaseBId)
            //.WillCascadeOnDelete(false);
            //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("server=ROCIORELLANO;database=BaseMR;trusted_connection=true;encrypt=False");
        }

        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<Medico>()
                // .HasOne(h => h.matriculaMedico)
                // .WithMany(p => p.Medicos)
                // .HasForeignKey(h => h.PersonaId)
                 .OnDelete(DeleteBehavior.Restrict); // Configura la restricción ON DELETE NO ACTION
         }
       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hijo>()
                .HasOne(h => h.Padre)
                .WithMany(p => p.Hijos)
                .HasForeignKey(h => h.PadreId)
                .OnDelete(DeleteBehavior.Restrict); // Configura la restricción ON DELETE NO ACTION
        }*/
    }
}

﻿// <auto-generated />
using System;
using Back;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(BaseDeDatosApp))]
    partial class BaseDeDatosAppModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Agenda", b =>
                {
                    b.Property<int>("idAgenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAgenda"));

                    b.Property<DateTime>("fechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("medicoAgendadni")
                        .HasColumnType("int");

                    b.Property<string>("paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAgenda");

                    b.HasIndex("medicoAgendadni");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("Back.Especialidad", b =>
                {
                    b.Property<int>("idEspecialidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEspecialidad"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idEspecialidad");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Back.Historial", b =>
                {
                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dni")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaHora")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("obraSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("nombre");

                    b.ToTable("Historiales");
                });

            modelBuilder.Entity("Back.Persona", b =>
                {
                    b.Property<int>("dni")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dni"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dni");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Back.Turno", b =>
                {
                    b.Property<int>("idTurno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTurno"));

                    b.Property<DateTime>("fechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("medicoTurnodni")
                        .HasColumnType("int");

                    b.Property<int>("pacienteTurnodni")
                        .HasColumnType("int");

                    b.HasKey("idTurno");

                    b.HasIndex("medicoTurnodni");

                    b.HasIndex("pacienteTurnodni");

                    b.ToTable("Turnos");
                });

            modelBuilder.Entity("Back.Medico", b =>
                {
                    b.HasBaseType("Back.Persona");

                    b.Property<int>("especialidadidEspecialidad")
                        .HasColumnType("int");

                    b.Property<string>("matriculaMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("usuarioMedicodni")
                        .HasColumnType("int");

                    b.HasIndex("especialidadidEspecialidad");

                    b.HasIndex("usuarioMedicodni");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("Back.Paciente", b =>
                {
                    b.HasBaseType("Back.Persona");

                    b.Property<double>("vacunasAlDia")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("Back.Secretaria", b =>
                {
                    b.HasBaseType("Back.Persona");

                    b.Property<int>("numerolegajo")
                        .HasColumnType("int");

                    b.Property<int>("usuarioSecretariadni")
                        .HasColumnType("int");

                    b.HasIndex("usuarioSecretariadni");

                    b.HasDiscriminator().HasValue("Secretaria");
                });

            modelBuilder.Entity("Back.Usuario", b =>
                {
                    b.HasBaseType("Back.Persona");

                    b.Property<string>("contrasenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("Back.Agenda", b =>
                {
                    b.HasOne("Back.Medico", "medicoAgenda")
                        .WithMany()
                        .HasForeignKey("medicoAgendadni")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("medicoAgenda");
                });

            modelBuilder.Entity("Back.Turno", b =>
                {
                    b.HasOne("Back.Medico", "medicoTurno")
                        .WithMany()
                        .HasForeignKey("medicoTurnodni")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back.Paciente", "pacienteTurno")
                        .WithMany()
                        .HasForeignKey("pacienteTurnodni")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("medicoTurno");

                    b.Navigation("pacienteTurno");
                });

            modelBuilder.Entity("Back.Medico", b =>
                {
                    b.HasOne("Back.Especialidad", "especialidad")
                        .WithMany()
                        .HasForeignKey("especialidadidEspecialidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back.Usuario", "usuarioMedico")
                        .WithMany()
                        .HasForeignKey("usuarioMedicodni")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("especialidad");

                    b.Navigation("usuarioMedico");
                });

            modelBuilder.Entity("Back.Secretaria", b =>
                {
                    b.HasOne("Back.Usuario", "usuarioSecretaria")
                        .WithMany()
                        .HasForeignKey("usuarioSecretariadni")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuarioSecretaria");
                });
#pragma warning restore 612, 618
        }
    }
}

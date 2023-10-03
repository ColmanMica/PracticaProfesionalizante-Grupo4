using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    idEspecialidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.idEspecialidad);
                });

            migrationBuilder.CreateTable(
                name: "Historiales",
                columns: table => new
                {
                    nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    obraSocial = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historiales", x => x.nombre);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    dni = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matriculaMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    especialidadidEspecialidad = table.Column<int>(type: "int", nullable: true),
                    usuarioMedicodni = table.Column<int>(type: "int", nullable: true),
                    vacunasAlDia = table.Column<double>(type: "float", nullable: true),
                    numerolegajo = table.Column<int>(type: "int", nullable: true),
                    usuarioSecretariadni = table.Column<int>(type: "int", nullable: true),
                    idUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.dni);
                    table.ForeignKey(
                        name: "FK_Personas_Especialidades_especialidadidEspecialidad",
                        column: x => x.especialidadidEspecialidad,
                        principalTable: "Especialidades",
                        principalColumn: "idEspecialidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_usuarioMedicodni",
                        column: x => x.usuarioMedicodni,
                        principalTable: "Personas",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_usuarioSecretariadni",
                        column: x => x.usuarioSecretariadni,
                        principalTable: "Personas",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    idAgenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    medicoAgendadni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.idAgenda);
                    table.ForeignKey(
                        name: "FK_Agendas_Personas_medicoAgendadni",
                        column: x => x.medicoAgendadni,
                        principalTable: "Personas",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    idTurno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    medicoTurnodni = table.Column<int>(type: "int", nullable: false),
                    pacienteTurnodni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.idTurno);
                    table.ForeignKey(
                        name: "FK_Turnos_Personas_medicoTurnodni",
                        column: x => x.medicoTurnodni,
                        principalTable: "Personas",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turnos_Personas_pacienteTurnodni",
                        column: x => x.pacienteTurnodni,
                        principalTable: "Personas",
                        principalColumn: "dni",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_medicoAgendadni",
                table: "Agendas",
                column: "medicoAgendadni");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_especialidadidEspecialidad",
                table: "Personas",
                column: "especialidadidEspecialidad");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_usuarioMedicodni",
                table: "Personas",
                column: "usuarioMedicodni");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_usuarioSecretariadni",
                table: "Personas",
                column: "usuarioSecretariadni");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_medicoTurnodni",
                table: "Turnos",
                column: "medicoTurnodni");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_pacienteTurnodni",
                table: "Turnos",
                column: "pacienteTurnodni");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendas");

            migrationBuilder.DropTable(
                name: "Historiales");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Especialidades");
        }
    }
}

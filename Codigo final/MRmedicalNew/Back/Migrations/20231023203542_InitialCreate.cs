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
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Historiales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    obraSocial = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historiales", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dni = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    matriculaMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    especialidadid = table.Column<int>(type: "int", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contrasenia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idpaciente = table.Column<int>(type: "int", nullable: true),
                    vacunasAlDia = table.Column<double>(type: "float", nullable: true),
                    idSecretaria = table.Column<int>(type: "int", nullable: true),
                    numerolegajo = table.Column<int>(type: "int", nullable: true),
                    usuarioSecretariaid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_Especialidades_especialidadid",
                        column: x => x.especialidadid,
                        principalTable: "Especialidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Usuarios_usuarioSecretariaid",
                        column: x => x.usuarioSecretariaid,
                        principalTable: "Usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    medicoAgendaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Agendas_Personas_medicoAgendaid",
                        column: x => x.medicoAgendaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    medicoTurnoid = table.Column<int>(type: "int", nullable: false),
                    pacienteTurnoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turnos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Turnos_Personas_medicoTurnoid",
                        column: x => x.medicoTurnoid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turnos_Personas_pacienteTurnoid",
                        column: x => x.pacienteTurnoid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendas_medicoAgendaid",
                table: "Agendas",
                column: "medicoAgendaid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_especialidadid",
                table: "Personas",
                column: "especialidadid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_usuarioSecretariaid",
                table: "Personas",
                column: "usuarioSecretariaid");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_medicoTurnoid",
                table: "Turnos",
                column: "medicoTurnoid");

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_pacienteTurnoid",
                table: "Turnos",
                column: "pacienteTurnoid");
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

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

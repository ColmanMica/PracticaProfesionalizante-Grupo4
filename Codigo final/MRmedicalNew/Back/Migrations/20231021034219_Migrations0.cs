using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Migrations
{
    /// <inheritdoc />
    public partial class Migrations0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Personas_medicoAgendaid",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Especialidades_especialidadid",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Usuarios_usuarioMedicoid",
                table: "Personas");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Personas_medicoAgendaid",
                table: "Agendas",
                column: "medicoAgendaid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Especialidades_especialidadid",
                table: "Personas",
                column: "especialidadid",
                principalTable: "Especialidades",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Usuarios_usuarioMedicoid",
                table: "Personas",
                column: "usuarioMedicoid",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendas_Personas_medicoAgendaid",
                table: "Agendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Especialidades_especialidadid",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Usuarios_usuarioMedicoid",
                table: "Personas");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendas_Personas_medicoAgendaid",
                table: "Agendas",
                column: "medicoAgendaid",
                principalTable: "Personas",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Especialidades_especialidadid",
                table: "Personas",
                column: "especialidadid",
                principalTable: "Especialidades",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Usuarios_usuarioMedicoid",
                table: "Personas",
                column: "usuarioMedicoid",
                principalTable: "Usuarios",
                principalColumn: "id");
        }
    }
}

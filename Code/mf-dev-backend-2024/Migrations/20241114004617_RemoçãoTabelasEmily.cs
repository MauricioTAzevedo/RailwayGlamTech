using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2024.Migrations
{
    /// <inheritdoc />
    public partial class RemoçãoTabelasEmily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorariosAgendados");

            migrationBuilder.DropTable(
                name: "HorariosDisponiveis");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HorariosDisponiveis",
                columns: table => new
                {
                    IdHorarioDisponivel = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProfissional = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFim = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraInicio = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosDisponiveis", x => x.IdHorarioDisponivel);
                    table.ForeignKey(
                        name: "FK_HorariosDisponiveis_Profissionais_IdProfissional",
                        column: x => x.IdProfissional,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HorariosAgendados",
                columns: table => new
                {
                    IdHorarioDisponivel = table.Column<int>(type: "int", nullable: false),
                    IdAgendamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorariosAgendados", x => new { x.IdHorarioDisponivel, x.IdAgendamento });
                    table.ForeignKey(
                        name: "FK_HorariosAgendados_Agendamentos_IdAgendamento",
                        column: x => x.IdAgendamento,
                        principalTable: "Agendamentos",
                        principalColumn: "IdAgendamento");
                    table.ForeignKey(
                        name: "FK_HorariosAgendados_HorariosDisponiveis_IdHorarioDisponivel",
                        column: x => x.IdHorarioDisponivel,
                        principalTable: "HorariosDisponiveis",
                        principalColumn: "IdHorarioDisponivel");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorariosAgendados_IdAgendamento",
                table: "HorariosAgendados",
                column: "IdAgendamento");

            migrationBuilder.CreateIndex(
                name: "IX_HorariosDisponiveis_IdProfissional",
                table: "HorariosDisponiveis",
                column: "IdProfissional");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2024.Migrations
{
    /// <inheritdoc />
    public partial class CreateHorarioAgendadoEmily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorariosAgendados");
        }
    }
}

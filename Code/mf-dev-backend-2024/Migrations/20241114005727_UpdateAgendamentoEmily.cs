using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2024.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAgendamentoEmily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Clientes_IdCliente",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Profissionais_IdProfissional",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_IdCliente",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_IdProfissional",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "IdProfissional",
                table: "Agendamentos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProfissional",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_IdCliente",
                table: "Agendamentos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_IdProfissional",
                table: "Agendamentos",
                column: "IdProfissional");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Clientes_IdCliente",
                table: "Agendamentos",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Profissionais_IdProfissional",
                table: "Agendamentos",
                column: "IdProfissional",
                principalTable: "Profissionais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

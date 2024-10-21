using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListaAfazeres.Migrations
{
    /// <inheritdoc />
    public partial class chave_estrangeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pessoaId",
                table: "Tarefa",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "pessoaId1",
                table: "Tarefa",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefa_pessoaId1",
                table: "Tarefa",
                column: "pessoaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefa_Pessoa_pessoaId1",
                table: "Tarefa",
                column: "pessoaId1",
                principalTable: "Pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefa_Pessoa_pessoaId1",
                table: "Tarefa");

            migrationBuilder.DropIndex(
                name: "IX_Tarefa_pessoaId1",
                table: "Tarefa");

            migrationBuilder.DropColumn(
                name: "pessoaId",
                table: "Tarefa");

            migrationBuilder.DropColumn(
                name: "pessoaId1",
                table: "Tarefa");
        }
    }
}

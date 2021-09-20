using Microsoft.EntityFrameworkCore.Migrations;

namespace CpmPedidos.Repository.Migrations
{
    public partial class _20092021_tatai_a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdEndereco",
                table: "tb_cliente",
                newName: "id_endereco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_endereco",
                table: "tb_cliente",
                newName: "IdEndereco");
        }
    }
}

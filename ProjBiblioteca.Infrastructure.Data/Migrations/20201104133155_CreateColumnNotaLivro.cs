using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjBiblioteca.Infrastructure.Data.Migrations
{
    public partial class CreateColumnNotaLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nota",
                table: "Livro",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Livro");
        }
    }
}

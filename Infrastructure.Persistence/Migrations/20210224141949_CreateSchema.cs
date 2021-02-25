using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Persistence.Migrations
{
    public partial class CreateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    Criacao = table.Column<DateTime>(nullable: false),
                    ModificadoPor = table.Column<string>(nullable: true),
                    Modificacao = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    CodigoDeBarras = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Taxa = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PRODUTO");
        }
    }
}

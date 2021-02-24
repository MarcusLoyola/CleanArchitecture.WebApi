using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Persistence.Migrations
{
    public partial class CustomNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "TB_PRODUTO");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "TB_PRODUTO",
                newName: "Taxa");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TB_PRODUTO",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "LastModifiedBy",
                table: "TB_PRODUTO",
                newName: "ModificadoPor");

            migrationBuilder.RenameColumn(
                name: "LastModified",
                table: "TB_PRODUTO",
                newName: "Modificacao");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "TB_PRODUTO",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "TB_PRODUTO",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "TB_PRODUTO",
                newName: "Criacao");

            migrationBuilder.RenameColumn(
                name: "Barcode",
                table: "TB_PRODUTO",
                newName: "CodigoDeBarras");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PRODUTO",
                table: "TB_PRODUTO",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PRODUTO",
                table: "TB_PRODUTO");

            migrationBuilder.RenameTable(
                name: "TB_PRODUTO",
                newName: "Products");

            migrationBuilder.RenameColumn(
                name: "Taxa",
                table: "Products",
                newName: "Rate");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ModificadoPor",
                table: "Products",
                newName: "LastModifiedBy");

            migrationBuilder.RenameColumn(
                name: "Modificacao",
                table: "Products",
                newName: "LastModified");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "Products",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "Criacao",
                table: "Products",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "CodigoDeBarras",
                table: "Products",
                newName: "Barcode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}

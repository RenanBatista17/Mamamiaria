using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Infrastructure.Migrations
{
    public partial class NovaTabelaPizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Categoria", "Descricao", "Preco", "Titulo" },
                values: new object[,]
                {
                    { 1, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 2, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 3, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 4, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 5, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 6, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 7, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 8, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 9, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 10, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 11, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" },
                    { 12, 0, "Pizza de calabresa, com queijo, cebola e molho de tomate.", 25.00m, "Pizza de Calabresa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}

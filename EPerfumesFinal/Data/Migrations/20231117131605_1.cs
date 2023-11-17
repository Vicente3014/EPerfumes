using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EPerfumesFinal.Data.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Marca_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Marca_Pic_URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfume_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Marca_ID);
                });

            migrationBuilder.CreateTable(
                name: "Perfumes",
                columns: table => new
                {
                    Perfume_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Perfume_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Perfume_Pic_URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamanho = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PerfumeType = table.Column<int>(type: "int", nullable: false),
                    PerfumeVersion = table.Column<int>(type: "int", nullable: false),
                    Marca_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfumes", x => x.Perfume_ID);
                    table.ForeignKey(
                        name: "FK_Perfumes_Marcas_Marca_ID",
                        column: x => x.Marca_ID,
                        principalTable: "Marcas",
                        principalColumn: "Marca_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_Perfume_ID",
                table: "Marcas",
                column: "Perfume_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Perfumes_Marca_ID",
                table: "Perfumes",
                column: "Marca_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Marcas_Perfumes_Perfume_ID",
                table: "Marcas",
                column: "Perfume_ID",
                principalTable: "Perfumes",
                principalColumn: "Perfume_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marcas_Perfumes_Perfume_ID",
                table: "Marcas");

            migrationBuilder.DropTable(
                name: "Perfumes");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}

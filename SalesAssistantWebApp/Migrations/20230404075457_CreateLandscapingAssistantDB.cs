using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesAssistantWebApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateLandscapingAssistantDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pavers",
                columns: table => new
                {
                    PaverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    canCrushRock = table.Column<bool>(type: "bit", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pavers", x => x.PaverId);
                });

            migrationBuilder.CreateTable(
                name: "RetainingWalls",
                columns: table => new
                {
                    RetainingWallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<float>(type: "real", nullable: false),
                    maxHeight = table.Column<int>(type: "int", nullable: false),
                    canCurve = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetainingWalls", x => x.RetainingWallId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pavers");

            migrationBuilder.DropTable(
                name: "RetainingWalls");
        }
    }
}

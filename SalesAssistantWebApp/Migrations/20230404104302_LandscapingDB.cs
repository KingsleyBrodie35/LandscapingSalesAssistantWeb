using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesAssistantWebApp.Migrations
{
    /// <inheritdoc />
    public partial class LandscapingDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "colour",
                table: "RetainingWalls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "colourCategory",
                table: "RetainingWalls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "Pavers",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<string>(
                name: "colour",
                table: "Pavers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "colourCategory",
                table: "Pavers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "colour",
                table: "RetainingWalls");

            migrationBuilder.DropColumn(
                name: "colourCategory",
                table: "RetainingWalls");

            migrationBuilder.DropColumn(
                name: "colour",
                table: "Pavers");

            migrationBuilder.DropColumn(
                name: "colourCategory",
                table: "Pavers");

            migrationBuilder.AlterColumn<float>(
                name: "price",
                table: "Pavers",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk3._0.Migrations
{
    public partial class NewMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Material",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "RushOrderCost",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "SurfaceAreaCostPerUnit",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "SurfaceAreaThreshold",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "SurfaceMaterialCost",
                table: "DeskQuote");

            migrationBuilder.AddColumn<string>(
                name: "DeskTopMaterial",
                table: "DeskQuote",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalCost",
                table: "DeskQuote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeskTopMaterial",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "DeskQuote");

            migrationBuilder.AddColumn<int>(
                name: "Material",
                table: "DeskQuote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RushOrderCost",
                table: "DeskQuote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurfaceAreaCostPerUnit",
                table: "DeskQuote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurfaceAreaThreshold",
                table: "DeskQuote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurfaceMaterialCost",
                table: "DeskQuote",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

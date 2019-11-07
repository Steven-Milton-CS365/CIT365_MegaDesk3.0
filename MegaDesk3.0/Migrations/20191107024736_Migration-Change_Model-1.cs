using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk3._0.Migrations
{
    public partial class MigrationChange_Model1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteAmount",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "SurfaceArea",
                table: "DeskQuote");

            migrationBuilder.AddColumn<int>(
                name: "SurfaceAreaCostPerUnit",
                table: "DeskQuote",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurfaceAreaThreshold",
                table: "DeskQuote",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurfaceAreaCostPerUnit",
                table: "DeskQuote");

            migrationBuilder.DropColumn(
                name: "SurfaceAreaThreshold",
                table: "DeskQuote");

            migrationBuilder.AddColumn<int>(
                name: "QuoteAmount",
                table: "DeskQuote",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SurfaceArea",
                table: "DeskQuote",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

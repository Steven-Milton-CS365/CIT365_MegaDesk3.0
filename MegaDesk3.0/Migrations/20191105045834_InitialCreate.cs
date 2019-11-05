using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaDesk3._0.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeskQuote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Width = table.Column<int>(nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    NumberOfDrawers = table.Column<int>(nullable: false),
                    SurfaceArea = table.Column<int>(nullable: false),
                    Material = table.Column<int>(nullable: false),
                    QuoteDate = table.Column<DateTime>(nullable: false),
                    CustomerName = table.Column<string>(nullable: false),
                    SurfaceMaterialCost = table.Column<int>(nullable: false),
                    RushDays = table.Column<int>(nullable: false),
                    RushOrderCost = table.Column<int>(nullable: false),
                    QuoteAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskQuote", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeskQuote");
        }
    }
}

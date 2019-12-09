using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Tittle = table.Column<string>(nullable: false),
                    ReleasedDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Poster = table.Column<byte[]>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Tittle);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}

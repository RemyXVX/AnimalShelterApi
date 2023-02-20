using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    public partial class V1kit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Date", "Description", "Name", "Type" },
                values: new object[] { 1, new DateTime(2023, 2, 20, 13, 26, 51, 374, DateTimeKind.Local).AddTicks(6240), "Hard worker but tiny hands. Has weird cravings for other dino buddies.", "Bob the Rex", "mr_hans" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Date", "Description", "Name", "Type" },
                values: new object[] { 2, new DateTime(2023, 2, 20, 13, 26, 51, 374, DateTimeKind.Local).AddTicks(6275), "No leaf is safe with bessy on the field. Could be the next NBA star for the dino leagues.", "Bessy the Longneck", "mr_hans" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Date", "Description", "Name", "Type" },
                values: new object[] { 3, new DateTime(2023, 2, 20, 13, 26, 51, 374, DateTimeKind.Local).AddTicks(6278), "Like to spend a lot of time underneath shade and strictly planet based. Doesn't like it because of how fierce their horns are.", "Pierre, with bullhorns", "mr_hans" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}

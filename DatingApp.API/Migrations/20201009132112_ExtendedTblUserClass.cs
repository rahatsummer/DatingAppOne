using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class ExtendedTblUserClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "tblUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "tblUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "tblUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "tblUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "tblUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "tblUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "tblUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KnownAs",
                table: "tblUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActive",
                table: "tblUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LookingFor",
                table: "tblUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "tblPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false),
                    UsersId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPhotos_tblUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPhotos_UsersId",
                table: "tblPhotos",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPhotos");

            migrationBuilder.DropColumn(
                name: "City",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "KnownAs",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "LastActive",
                table: "tblUsers");

            migrationBuilder.DropColumn(
                name: "LookingFor",
                table: "tblUsers");
        }
    }
}

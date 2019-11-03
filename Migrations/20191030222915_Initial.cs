using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyHomies.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "timeCheckedOut",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "checkOutTime",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "checkedOut",
                table: "Item",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "reservedTime",
                table: "Item",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "checkOutTime",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "checkedOut",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "reservedTime",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "timeCheckedOut",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

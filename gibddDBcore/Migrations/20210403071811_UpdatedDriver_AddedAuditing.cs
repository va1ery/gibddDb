using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gibddDBcore.Migrations
{
    public partial class UpdatedDriver_AddedAuditing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                table: "Drivers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Drivers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Drivers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Drivers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LastModifiedUserId",
                table: "Drivers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "LastModifiedUserId",
                table: "Drivers");
        }
    }
}

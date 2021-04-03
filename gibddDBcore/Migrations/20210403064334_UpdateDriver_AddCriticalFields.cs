using Microsoft.EntityFrameworkCore.Migrations;

namespace gibddDBcore.Migrations
{
    public partial class UpdateDriver_AddCriticalFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "company",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "jobname",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "passportNumber",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "photo",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "postcode",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "company",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "jobname",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "passportNumber",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "photo",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "postcode",
                table: "Drivers");
        }
    }
}

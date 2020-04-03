using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class UpdateProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Businesses",
                newName: "Longitude");

            migrationBuilder.AddColumn<bool>(
                name: "ADA",
                table: "Businesses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "Latitude",
                table: "Businesses",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "MainAddress",
                table: "Businesses",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                columns: new[] { "ADA", "Latitude", "Longitude", "MainAddress" },
                values: new object[] { true, 123.456767m, 345.67878m, "456 Street" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                columns: new[] { "ADA", "Latitude", "Longitude", "MainAddress" },
                values: new object[] { true, 123.123123m, 678.23456m, "567 Street" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                columns: new[] { "Latitude", "Longitude", "MainAddress" },
                values: new object[] { 123.123m, 456.23456m, "876 Street" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6,
                columns: new[] { "ADA", "Latitude", "Longitude", "MainAddress" },
                values: new object[] { true, 123.123132m, 234.34556m, "123 Street" });

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7,
                columns: new[] { "Latitude", "MainAddress" },
                values: new object[] { 234.43589m, "234 Street" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ADA",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Businesses");

            migrationBuilder.DropColumn(
                name: "MainAddress",
                table: "Businesses");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Businesses",
                newName: "Location");

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3,
                column: "Location",
                value: 123.456767m);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4,
                column: "Location",
                value: 123.123123m);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5,
                column: "Location",
                value: 123.123m);

            migrationBuilder.UpdateData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6,
                column: "Location",
                value: 123.123132m);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalBusiness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "CertNumber", "Email", "Location", "Manager", "Name", "Phone", "YearJoined" },
                values: new object[,]
                {
                    { 6, 1234, "sde@asdf.com", 123.123132m, "Tom", "Tiki", "123-2345", 2007 },
                    { 7, 2345, "asd@asdf.com", 123.123456m, "Fred", "Rexie", "123-1234", 2010 },
                    { 3, 3456, "arc@asdf.com", 123.456767m, "Steve", "Matilda", "234-3456", 2002 },
                    { 4, 4567, "asd@asd.com", 123.123123m, "Becky", "Pip", "123-345-3456", 2004 },
                    { 5, 5678, "ngr@asds.com", 123.123m, "Dinosaur", "Annie", "234-2345", 2022 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7);
        }
    }
}

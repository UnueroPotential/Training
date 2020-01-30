using Microsoft.EntityFrameworkCore.Migrations;

namespace Training.Data.Migrations
{
    public partial class aspuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc52a722-d311-4610-af22-c3533e6eef11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd6eee67-fe48-4be4-826a-181ea8386c8c");

            migrationBuilder.RenameColumn(
                name: "OtherDescription",
                table: "AspNetUsers",
                newName: "Other_Description");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f131f119-aa3a-431c-afc5-f61001d8edbb", "6fdf1d60-50ec-4aeb-a135-3a12138b8df0", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3be152ea-1cfd-40b8-83c6-722a17b8c482", "f8f655a2-54a9-419c-9c80-c5ccfd07c7e3", "staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3be152ea-1cfd-40b8-83c6-722a17b8c482");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f131f119-aa3a-431c-afc5-f61001d8edbb");

            migrationBuilder.RenameColumn(
                name: "Other_Description",
                table: "AspNetUsers",
                newName: "OtherDescription");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc52a722-d311-4610-af22-c3533e6eef11", "bd32fe27-5e11-4040-8f54-70bb75bec5e7", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd6eee67-fe48-4be4-826a-181ea8386c8c", "9ba8e2b6-05a1-4f17-b7e4-baa4d02a164c", "staff", "STAFF" });
        }
    }
}

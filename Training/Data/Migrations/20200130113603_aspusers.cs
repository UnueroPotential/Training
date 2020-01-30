using Microsoft.EntityFrameworkCore.Migrations;

namespace Training.Data.Migrations
{
    public partial class aspusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3be152ea-1cfd-40b8-83c6-722a17b8c482");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f131f119-aa3a-431c-afc5-f61001d8edbb");

            migrationBuilder.DropColumn(
                name: "Other_Description",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09a85e99-072b-4799-b6d1-c78b21e4b637", "55438174-a004-42d6-aca1-9f93efca1f9e", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26ce3bbf-461d-4d09-85f1-d50873525044", "778791dc-a4be-4ef6-91b9-cfd583f72075", "staff", "STAFF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09a85e99-072b-4799-b6d1-c78b21e4b637");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26ce3bbf-461d-4d09-85f1-d50873525044");

            migrationBuilder.AddColumn<string>(
                name: "Other_Description",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f131f119-aa3a-431c-afc5-f61001d8edbb", "6fdf1d60-50ec-4aeb-a135-3a12138b8df0", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3be152ea-1cfd-40b8-83c6-722a17b8c482", "f8f655a2-54a9-419c-9c80-c5ccfd07c7e3", "staff", "STAFF" });
        }
    }
}

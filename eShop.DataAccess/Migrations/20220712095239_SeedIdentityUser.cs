using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShop.DataAccess.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("537d9a49-e1d3-4777-9f49-66ae5e5c93e4"), "7539edb4-bada-4690-ac60-b247e832f36f", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("537d9a49-e1d3-4777-9f49-66ae5e5c93e4"), new Guid("29910f72-72a1-4b6b-92d1-dbe61d335b30") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("29910f72-72a1-4b6b-92d1-dbe61d335b30"), 0, "47772b8f-c6ed-4cb9-925e-0ad9f1a7671b", new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "phucle23899@gmail.com", true, "Phuc", "Le", false, null, "some-admin-email@nonce.fake", "admin", "AQAAAAEAACcQAAAAEGgkG9Lc4JfMxG78Io4e2aeVZp23s9BjWEx4Wu+5aoZLkQPdCrie/ixmVJsY2qekDw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 12, 16, 52, 39, 17, DateTimeKind.Local).AddTicks(9854));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("537d9a49-e1d3-4777-9f49-66ae5e5c93e4"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("537d9a49-e1d3-4777-9f49-66ae5e5c93e4"), new Guid("29910f72-72a1-4b6b-92d1-dbe61d335b30") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("29910f72-72a1-4b6b-92d1-dbe61d335b30"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 7, 12, 16, 35, 18, 665, DateTimeKind.Local).AddTicks(2369));
        }
    }
}

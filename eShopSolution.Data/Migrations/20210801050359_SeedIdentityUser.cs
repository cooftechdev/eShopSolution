using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 1, 12, 3, 58, 740, DateTimeKind.Local).AddTicks(6103),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 1, 11, 33, 34, 6, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("056674a3-5fc3-48d2-9625-4cfb6ee83b8b"), "4003e58d-036a-4d2e-9c29-0a5b10bf2aea", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("ba03c52c-b5fa-427f-8894-93e8c2e98598"), new Guid("056674a3-5fc3-48d2-9625-4cfb6ee83b8b") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("ba03c52c-b5fa-427f-8894-93e8c2e98598"), 0, "4207210f-eb26-4db4-84a2-bad849e0b20e", new DateTime(1988, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "baolocc21@gmail.com", true, "Loc", "Bao", false, null, "baolocc21@gmail.com", "admin", "AQAAAAEAACcQAAAAEBhz9pTe1EXPf4HodJMq9AH0SRTZ5XiwXWZfmiDORN+gkTglt4APF7Bn2wwuu6Rtvw==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { new DateTime(2021, 8, 1, 12, 3, 58, 770, DateTimeKind.Local).AddTicks(3661), 100000m, 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("056674a3-5fc3-48d2-9625-4cfb6ee83b8b"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("ba03c52c-b5fa-427f-8894-93e8c2e98598"), new Guid("056674a3-5fc3-48d2-9625-4cfb6ee83b8b") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba03c52c-b5fa-427f-8894-93e8c2e98598"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 1, 11, 33, 34, 6, DateTimeKind.Local).AddTicks(9478),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 8, 1, 12, 3, 58, 740, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OriginalPrice", "Price" },
                values: new object[] { new DateTime(2021, 8, 1, 11, 33, 34, 35, DateTimeKind.Local).AddTicks(4330), 100000m, 200000m });
        }
    }
}

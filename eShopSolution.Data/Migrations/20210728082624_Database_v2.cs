using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class Database_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Languages_LaguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTranslations_LaguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropColumn(
                name: "LaguageId",
                table: "ProductTranslations");

            migrationBuilder.DropColumn(
                name: "LaguageId",
                table: "CategoryTranslations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 15, 26, 23, 883, DateTimeKind.Local).AddTicks(8321),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 7, 28, 6, 13, 54, 179, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.AlterColumn<bool>(
                name: "IsDefault",
                table: "Languages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "LanguageId",
                table: "CategoryTranslations",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryTranslations_Languages_LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropIndex(
                name: "IX_CategoryTranslations_LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "CategoryTranslations");

            migrationBuilder.AddColumn<int>(
                name: "LaguageId",
                table: "ProductTranslations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 7, 28, 6, 13, 54, 179, DateTimeKind.Local).AddTicks(6026),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 7, 28, 15, 26, 23, 883, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.AlterColumn<int>(
                name: "IsDefault",
                table: "Languages",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "LaguageId",
                table: "CategoryTranslations",
                type: "varchar(5)",
                unicode: false,
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTranslations_LaguageId",
                table: "CategoryTranslations",
                column: "LaguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryTranslations_Languages_LaguageId",
                table: "CategoryTranslations",
                column: "LaguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPProject.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Addinguserdataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CreatorUserId",
                schema: "Person",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                schema: "Person",
                table: "Users",
                columns: new[] { "Id", "CreationTime", "CreatorUserId", "FullName", "LastModifiedTime", "LastModifiedUserId", "UserAddress", "UserEmail", "UserMobile" },
                values: new object[] { 1, new DateTime(2024, 4, 27, 11, 47, 16, 85, DateTimeKind.Unspecified).AddTicks(3682), null, "Bijay Adhikari", null, null, "Thaiba, Lalitpur", "bijay.adhikari.27648@gmail.com", "9800000000" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Person",
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "CreatorUserId",
                schema: "Person",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}

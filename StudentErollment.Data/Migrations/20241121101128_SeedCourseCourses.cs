using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentErollment.Data.Migrations
{
    public partial class SeedCourseCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Credits",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "af4227aa-a9a3-4773-819a-b5e97d28a4d3", "43786f24-3fda-4ce0-b430-6c22eca30d2e", "User", "USER" },
                    { "bb95371a-3d0b-4048-ae1c-ab165fc4670e", "aab3c1bf-3599-47ee-bc88-9671ca02b140", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Credits", "MordifiedBy", "MordifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minimum Api development" },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "advance Api development" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af4227aa-a9a3-4773-819a-b5e97d28a4d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb95371a-3d0b-4048-ae1c-ab165fc4670e");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Credits",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

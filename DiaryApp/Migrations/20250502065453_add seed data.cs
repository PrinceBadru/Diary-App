using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class addseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "DiaryEntries",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "DiaryEntries",
                newName: "Created");

            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Created", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 2, 9, 54, 51, 711, DateTimeKind.Local).AddTicks(5923), "Went Hiking with Joey", "Went Hiking" },
                    { 2, new DateTime(2025, 5, 2, 9, 54, 51, 711, DateTimeKind.Local).AddTicks(6605), "Went Hiking with Joey", "Went Hiking" },
                    { 3, new DateTime(2025, 5, 2, 9, 54, 51, 711, DateTimeKind.Local).AddTicks(6608), "Went Hiking with Joey", "Went Hiking" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "DiaryEntries",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "DiaryEntries",
                newName: "DateTime");
        }
    }
}

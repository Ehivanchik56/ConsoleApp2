using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp2.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "IdCategory", "Name" },
                values: new object[,]
                {
                    { new Guid("5cf656b3-d186-4062-b798-c5824d9a7002"), "Фрукты" },
                    { new Guid("9aa9ae5e-615b-4cc8-8a7c-49947fc20718"), "Овощи" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("5cf656b3-d186-4062-b798-c5824d9a7002"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "IdCategory",
                keyValue: new Guid("9aa9ae5e-615b-4cc8-8a7c-49947fc20718"));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DutchTreat.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "OrderDate", "OrderNumber" },
                values: new object[] { 1, new DateTime(2021, 7, 20, 14, 1, 42, 924, DateTimeKind.Utc).AddTicks(7463), "12345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

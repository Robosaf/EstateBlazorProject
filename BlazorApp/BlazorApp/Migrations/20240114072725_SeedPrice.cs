using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Price",
                table: "Premises",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 3000000L);

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 4000000L);

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 250000L);

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 3450000L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Premises");
        }
    }
}

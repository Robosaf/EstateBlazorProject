using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class ToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "Premises",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Premises",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Size" },
                values: new object[] { 3000000, 129 });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Size" },
                values: new object[] { 4000000, 180 });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Size" },
                values: new object[] { 250000, 210 });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Size" },
                values: new object[] { 3450000, 99 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Size",
                table: "Premises",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "Premises",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Size" },
                values: new object[] { 3000000L, 129L });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Size" },
                values: new object[] { 4000000L, 180L });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Size" },
                values: new object[] { 250000L, 210L });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Size" },
                values: new object[] { 3450000L, 99L });
        }
    }
}

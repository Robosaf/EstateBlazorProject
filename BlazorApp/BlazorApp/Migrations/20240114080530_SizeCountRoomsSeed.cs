using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class SizeCountRoomsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomsCount",
                table: "Premises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Size",
                table: "Premises",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RoomsCount", "Size" },
                values: new object[] { 5, 129L });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "RoomsCount", "Size" },
                values: new object[] { 7, 180L });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "RoomsCount", "Size" },
                values: new object[] { 10, 210L });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "RoomsCount", "Size" },
                values: new object[] { 3, 99L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomsCount",
                table: "Premises");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Premises");
        }
    }
}

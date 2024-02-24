using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class LocationFeatureSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Premises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Premises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PremiseFeatures",
                columns: table => new
                {
                    PremiseId = table.Column<int>(type: "int", nullable: false),
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremiseFeatures", x => new { x.PremiseId, x.FeatureId });
                    table.ForeignKey(
                        name: "FK_PremiseFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PremiseFeatures_Premises_PremiseId",
                        column: x => x.PremiseId,
                        principalTable: "Premises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Security System" },
                    { 2, "High-Speed Internet Connectivity" },
                    { 3, "Energy-Efficient Lighting" },
                    { 4, "Flexible Workspace" },
                    { 5, "Smart HVAC Systems" },
                    { 6, "Customizable Interior Layouts" },
                    { 7, "Green Spaces" },
                    { 8, "Meeting Rooms with Tech Infrastructure" },
                    { 9, "Accessibility Features" },
                    { 10, "Waste Management Systems" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Country" },
                values: new object[,]
                {
                    { 1, "Warsaw", "Poland" },
                    { 2, "Gdansk", "Poland" }
                });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LocationId", "Street" },
                values: new object[] { 1, "Pulawska" });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LocationId", "Street" },
                values: new object[] { 1, "Zlota" });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LocationId", "Street" },
                values: new object[] { 2, "Kazimierza Porebicza" });

            migrationBuilder.UpdateData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LocationId", "Street" },
                values: new object[] { 1, "Bulana Zlotego" });

            migrationBuilder.InsertData(
                table: "PremiseFeatures",
                columns: new[] { "FeatureId", "PremiseId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 4, 1 },
                    { 6, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 7, 2 },
                    { 4, 3 },
                    { 9, 3 },
                    { 10, 3 },
                    { 3, 4 },
                    { 6, 4 },
                    { 8, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Premises_LocationId",
                table: "Premises",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PremiseFeatures_FeatureId",
                table: "PremiseFeatures",
                column: "FeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Premises_Locations_LocationId",
                table: "Premises",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Premises_Locations_LocationId",
                table: "Premises");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "PremiseFeatures");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Premises_LocationId",
                table: "Premises");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Premises");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Premises");
        }
    }
}

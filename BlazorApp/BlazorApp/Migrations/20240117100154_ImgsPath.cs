using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class ImgsPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 10, 3 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "PremiseFeatures",
                keyColumns: new[] { "FeatureId", "PremiseId" },
                keyValues: new object[] { 8, 4 });

            migrationBuilder.DeleteData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Premises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Premises",
                newName: "ImgPath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgPath",
                table: "Premises",
                newName: "ImageUrl");

            migrationBuilder.InsertData(
                table: "Premises",
                columns: new[] { "Id", "Description", "ImageUrl", "LocationId", "Price", "RoomsCount", "Size", "Street", "Title" },
                values: new object[,]
                {
                    { 1, "Single room in unit (2+1) - from 430 EUR / month - 10-12 sqm - Fully furnished with a bed with storage space, comfortable mattress, desk and chair, wardrobe. Shared fridge in the hall with max. two persons - Shared bathroom with max. two persons. Nearby services: - Bus stop (160 meters) - Tram stop (350 meters) - Bars, restaurants and clubs - One of the greenest area in Warsaw. Feature check-list: - 24/7 reception support & security - High speed WiFi - Rooftop terrace, cinema room, shared kitchens, laundry room, study room, chill out zone - One card for everything - Front door, room door", "https://hotelverte.com/wp-content/uploads/2023/12/top-things-to-do-in-warsaw-old-town.jpg", 1, 3000000, 5, 129, "Pulawska", "Warsaw House" },
                    { 2, "Tucked away at the edge of an ancient forest, this whimsical cottage seems plucked from the pages of a fairy tale. Its charming exterior, adorned with climbing ivy and surrounded by a vibrant garden, invites you into a world of enchantment. Inside, the warm glow of a fireplace dances on rustic wooden beams, creating a cozy atmosphere. Unique stained glass windows add a touch of magic to each room, casting colorful patterns that change with the shifting sunlight. The Enchanted Cottage is a haven for those seeking a retreat into a storybook setting.", "https://thumbor.forbes.com/thumbor/fit-in/900x510/https://www.forbes.com/home-improvement/wp-content/uploads/2022/07/download-23.jpg", 1, 4000000, 7, 180, "Zlota", "Warsaw Flat White" },
                    { 3, "Rising amidst the bustling cityscape, this sleek and stylish modern residence stands as a testament to contemporary design. The exterior's clean lines and large windows offer panoramic views of the surrounding urban jungle. Inside, an open-concept living space is adorned with minimalist furnishings, creating a sense of spaciousness. Smart home technology seamlessly integrates into every corner, allowing residents to control the ambiance with a touch. A rooftop terrace provides a private escape, offering a breathtaking skyline as a backdrop to the rhythmic pulse of the city below.", "https://mygate.com/wp-content/uploads/2023/07/110.jpg", 2, 250000, 10, 210, "Kazimierza Porebicza", "Gdansk Home" },
                    { 4, "Nestled on the shores of a tranquil lake, this rustic yet elegant house exudes a timeless charm. Weathered stone and cedar shingles blend seamlessly with the natural surroundings, while a sprawling porch offers a front-row seat to breathtaking sunsets. Inside, exposed wooden beams and a grand stone fireplace create a warm and inviting atmosphere. Large windows frame picturesque views of the lake, blurring the lines between indoor and outdoor living. A private dock extends into the water, inviting residents to embrace a serene lakeside lifestyle in this idyllic retreat.", "https://i.pinimg.com/736x/d0/c0/4b/d0c04be7f982a0753cb6dc0c565ea661.jpg", 1, 3450000, 3, 99, "Bulana Zlotego", "Flat in Warsaw center" }
                });

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
        }
    }
}

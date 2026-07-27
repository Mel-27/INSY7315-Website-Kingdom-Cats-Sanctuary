using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace INSY7315Prototype.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "TagsCsv" },
                values: new object[] { "Adult", "Friendly,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AgeDisplay", "Category", "Gender", "Name", "TagsCsv" },
                values: new object[] { "3 Years", "Adult", "Female", "Bella", "Loving,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AgeDisplay", "Category", "Name", "TagsCsv" },
                values: new object[] { "5 Years", "Adult", "Leo", "Gentle,Quiet" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AgeDisplay", "Category", "Name", "TagsCsv" },
                values: new object[] { "2 Years", "Adult", "Milo", "Calm,Affectionate" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Gender", "Name", "TagsCsv" },
                values: new object[] { "Adult", "Female", "Daisy", "Active,Curious" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AgeDisplay", "Category", "Name", "TagsCsv" },
                values: new object[] { "4 Years", "Adult", "Charlie", "Shy,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AgeDisplay", "Category", "Gender", "Name", "TagsCsv" },
                values: new object[] { "8 Months", "Kitten", "Female", "Coco", "Playful,Curious" });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "AdoptionStatus", "AgeDisplay", "Badge", "Category", "Gender", "Name", "PhotoUrl", "TagsCsv" },
                values: new object[,]
                {
                    { 12, "Available", "3 Years", "Staff Favorite", "Adult", "Male", "Simba", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob12.jpeg", "Friendly,Playful" },
                    { 13, "Available", "2 Years", null, "Adult", "Female", "Nala", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob13.jpeg", "Affectionate,Indoor Only" },
                    { 14, "Available", "6 Years", null, "Senior", "Male", "Tiger", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob14.jpeg", "Calm,Independent" },
                    { 15, "Available", "1 Year", "New Arrival", "Adult", "Female", "Lily", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob15.jpeg", "Sweet,Playful" },
                    { 16, "Available", "5 Years", null, "Adult", "Male", "Oscar", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob16.jpeg", "Friendly,Lap Cat" },
                    { 17, "Available", "7 Months", null, "Kitten", "Female", "Ruby", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob17.jpeg", "Energetic,Vocal" },
                    { 18, "Available", "4 Years", null, "Adult", "Male", "Jasper", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob18.jpeg", "Gentle,Indoor Only" },
                    { 19, "Available", "10 Years", null, "Senior", "Female", "Rosie", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob19.jpeg", "Calm,Loving" },
                    { 20, "Available", "3 Years", null, "Adult", "Male", "Shadow", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob20.jpeg", "Quiet,Affectionate" },
                    { 21, "Available", "2 Years", null, "Adult", "Female", "Lucy", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob21.jpeg", "Friendly,Good with Kids" },
                    { 22, "Available", "5 Years", null, "Adult", "Male", "Max", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob22.jpeg", "Playful,Curious" },
                    { 23, "Available", "4 Years", null, "Adult", "Female", "Chloe", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob23.jpeg", "Gentle,Quiet" },
                    { 24, "Available", "6 Years", null, "Senior", "Male", "Rocky", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob24.jpeg", "Calm,Independent" },
                    { 25, "Available", "9 Months", "New Arrival", "Kitten", "Female", "Sophie", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob25.jpeg", "Playful,Affectionate" },
                    { 26, "Available", "2 Years", null, "Adult", "Male", "Finn", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob26.jpeg", "Energetic,Friendly" },
                    { 27, "Available", "3 Years", null, "Adult", "Female", "Willow", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob27.jpeg", "Shy,Gentle" },
                    { 28, "Available", "5 Years", null, "Adult", "Male", "Zeus", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob28.jpeg", "Protective,Loving" },
                    { 29, "Available", "11 Years", null, "Senior", "Female", "Misty", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob29.jpeg", "Calm,Lap Cat" },
                    { 30, "Available", "1 Year", null, "Adult", "Male", "Buddy", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob30.jpeg", "Friendly,Active" },
                    { 31, "Available", "2 Years", null, "Adult", "Female", "Hazel", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob31.jpeg", "Curious,Sweet" },
                    { 32, "Available", "7 Years", null, "Senior", "Male", "Smokey", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob32.jpeg", "Gentle,Quiet" },
                    { 33, "Available", "8 Months", null, "Kitten", "Female", "Poppy", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob33.jpeg", "Playful,Vocal" },
                    { 34, "Available", "3 Years", null, "Adult", "Male", "Archie", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob34.jpeg", "Friendly,Indoor Only" },
                    { 35, "Available", "4 Years", null, "Adult", "Female", "Pepper", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob35.jpeg", "Affectionate,Calm" },
                    { 36, "Available", "6 Years", null, "Senior", "Male", "George", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob36.jpeg", "Relaxed,Gentle" },
                    { 37, "Available", "1 Year", "New Arrival", "Adult", "Female", "Zoe", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob37.jpeg", "Friendly,Curious" },
                    { 38, "Available", "2 Years", null, "Adult", "Male", "Theo", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob38.jpeg", "Playful,Affectionate" },
                    { 39, "Available", "5 Years", null, "Adult", "Female", "Cleo", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob39.jpeg", "Calm,Loving" },
                    { 40, "Available", "3 Years", "Special Needs", "Adult", "Male", "Binx", "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob40.jpeg", "Gentle,Special Needs,Indoor Only" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "TagsCsv" },
                values: new object[] { "SpecialNeeds", "Special Needs,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AgeDisplay", "Category", "Gender", "Name", "TagsCsv" },
                values: new object[] { "1 Year", "SpecialNeeds", "Male", "Patch", "Special Needs,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AgeDisplay", "Category", "Name", "TagsCsv" },
                values: new object[] { "1 Year", "SpecialNeeds", "Patch", "Special Needs,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AgeDisplay", "Category", "Name", "TagsCsv" },
                values: new object[] { "1 Year", "SpecialNeeds", "Patch", "Special Needs,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Gender", "Name", "TagsCsv" },
                values: new object[] { "SpecialNeeds", "Male", "Patch", "Special Needs,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AgeDisplay", "Category", "Name", "TagsCsv" },
                values: new object[] { "1 Year", "SpecialNeeds", "Patch", "Special Needs,Gentle" });

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AgeDisplay", "Category", "Gender", "Name", "TagsCsv" },
                values: new object[] { "1 Year", "SpecialNeeds", "Male", "Patch", "Special Needs,Gentle" });
        }
    }
}

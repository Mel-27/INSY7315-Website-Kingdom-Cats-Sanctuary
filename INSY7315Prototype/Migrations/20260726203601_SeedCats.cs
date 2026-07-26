using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace INSY7315Prototype.Migrations
{
    /// <inheritdoc />
    public partial class SeedCats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeDisplay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Badge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagsCsv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdoptionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "AdoptionStatus", "AgeDisplay", "Badge", "Category", "Gender", "Name", "PhotoUrl", "TagsCsv" },
                values: new object[,]
                {
                    { 1, "Available", "2 Years", "New Arrival", "Adult", "Male", "Oliver", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob1.jpeg", "Cuddly,Indoor Only" },
                    { 2, "Available", "4 Years", "Staff Favorite", "Adult", "Female", "Luna", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob2.jpeg", "Playful,Good with Dogs" },
                    { 3, "Available", "6 Months", null, "Kitten", "Female", "Mochi", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob3.jpeg", "Energetic,Vocal" },
                    { 4, "Available", "9 Years", null, "Senior", "Male", "Whiskers", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob4.jpeg", "Calm,Lap Cat" },
                    { 5, "Available", "1 Year", null, "SpecialNeeds", "Male", "Patch", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob5.jpeg", "Special Needs,Gentle" },
                    { 6, "Available", "1 Year", null, "SpecialNeeds", "Male", "Patch", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob6.jpeg", "Special Needs,Gentle" },
                    { 7, "Available", "1 Year", null, "SpecialNeeds", "Male", "Patch", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob7.jpeg", "Special Needs,Gentle" },
                    { 8, "Available", "1 Year", null, "SpecialNeeds", "Male", "Patch", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob8.jpeg", "Special Needs,Gentle" },
                    { 9, "Available", "1 Year", null, "SpecialNeeds", "Male", "Patch", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob9.jpeg", "Special Needs,Gentle" },
                    { 10, "Available", "1 Year", null, "SpecialNeeds", "Male", "Patch", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob10.jpeg", "Special Needs,Gentle" },
                    { 11, "Available", "1 Year", null, "SpecialNeeds", "Male", "Patch", "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob11.jpeg", "Special Needs,Gentle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");
        }
    }
}

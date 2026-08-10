using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSY7315Prototype.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Badge", "Description", "TagsCsv" },
                values: new object[] { "New Arrival", "Binx is very loving and friendly, he thrives best in a calm, dedicated indoor home. He's gentle and deeply grateful for the extra care and patience of the right adopter.", "Gentle,Indoor Only" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Badge", "Description", "TagsCsv" },
                values: new object[] { "Special Needs", "Binx has some special needs that mean he thrives best in a calm, dedicated indoor home. He's gentle and deeply grateful for the extra care and patience of the right adopter.", "Gentle,Special Needs,Indoor Only" });
        }
    }
}

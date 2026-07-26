using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSY7315Prototype.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob1.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob2.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob3.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob4.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob5.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob6.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob7.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob8.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob9.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob10.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 11,
                column: "PhotoUrl",
                value: "https://kingdomcatstorage.blob.core.windows.net/catprofile/blob11.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob1.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob2.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob3.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob4.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob5.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob6.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob7.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob8.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob9.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob10.jpeg");

            migrationBuilder.UpdateData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 11,
                column: "PhotoUrl",
                value: "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer/blob11.jpeg");
        }
    }
}

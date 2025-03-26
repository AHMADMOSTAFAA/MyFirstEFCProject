using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportify.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedImagesandchangedrelationbetweenuserandplacetoonetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "placeOfInterests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests",
                column: "ownerid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "placeOfInterests");

            migrationBuilder.CreateIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests",
                column: "ownerid",
                unique: true);
        }
    }
}

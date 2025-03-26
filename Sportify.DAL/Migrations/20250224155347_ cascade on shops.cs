using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportify.DAL.Migrations
{
    /// <inheritdoc />
    public partial class cascadeonshops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops");

            migrationBuilder.AddForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops",
                column: "PlaceId",
                principalTable: "placeOfInterests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops");

            migrationBuilder.AddForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops",
                column: "PlaceId",
                principalTable: "placeOfInterests",
                principalColumn: "Id");
        }
    }
}

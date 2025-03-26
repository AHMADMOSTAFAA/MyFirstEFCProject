using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportify.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Addednavpropofshopsinplace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops");

            migrationBuilder.DropIndex(
                name: "IX_shops_PlaceId",
                table: "shops");

            migrationBuilder.CreateIndex(
                name: "IX_shops_PlaceId",
                table: "shops",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops",
                column: "PlaceId",
                principalTable: "placeOfInterests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops");

            migrationBuilder.DropIndex(
                name: "IX_shops_PlaceId",
                table: "shops");

            migrationBuilder.CreateIndex(
                name: "IX_shops_PlaceId",
                table: "shops",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops",
                column: "PlaceId",
                principalTable: "placeOfInterests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

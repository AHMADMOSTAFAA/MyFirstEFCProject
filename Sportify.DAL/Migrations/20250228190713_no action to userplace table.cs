using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportify.DAL.Migrations
{
    /// <inheritdoc />
    public partial class noactiontouserplacetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userPlaceOfIntrests_placeOfInterests_PlaceId",
                table: "userPlaceOfIntrests");

            migrationBuilder.DropForeignKey(
                name: "FK_userPlaceOfIntrests_users_UserId",
                table: "userPlaceOfIntrests");

            migrationBuilder.AddForeignKey(
                name: "FK_userPlaceOfIntrests_placeOfInterests_PlaceId",
                table: "userPlaceOfIntrests",
                column: "PlaceId",
                principalTable: "placeOfInterests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userPlaceOfIntrests_users_UserId",
                table: "userPlaceOfIntrests",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userPlaceOfIntrests_placeOfInterests_PlaceId",
                table: "userPlaceOfIntrests");

            migrationBuilder.DropForeignKey(
                name: "FK_userPlaceOfIntrests_users_UserId",
                table: "userPlaceOfIntrests");

            migrationBuilder.AddForeignKey(
                name: "FK_userPlaceOfIntrests_placeOfInterests_PlaceId",
                table: "userPlaceOfIntrests",
                column: "PlaceId",
                principalTable: "placeOfInterests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userPlaceOfIntrests_users_UserId",
                table: "userPlaceOfIntrests",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

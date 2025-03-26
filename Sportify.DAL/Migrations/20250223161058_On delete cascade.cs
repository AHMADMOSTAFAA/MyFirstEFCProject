using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportify.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Ondeletecascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_placeOfInterests_users_ownerid",
                table: "placeOfInterests");

            migrationBuilder.DropForeignKey(
                name: "FK_products_shops_ShopId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops");

            migrationBuilder.DropForeignKey(
                name: "FK_shops_users_UserId",
                table: "shops");

            migrationBuilder.DropForeignKey(
                name: "FK_userPlaceOfIntrests_users_UserId",
                table: "userPlaceOfIntrests");

            migrationBuilder.DropIndex(
                name: "IX_shops_PlaceId",
                table: "shops");

            migrationBuilder.DropIndex(
                name: "IX_shops_UserId",
                table: "shops");

            migrationBuilder.DropIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "shops");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ownerid",
                table: "placeOfInterests",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_shops_PlaceId",
                table: "shops",
                column: "PlaceId",
                unique: true,
                filter: "[PlaceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests",
                column: "ownerid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_placeOfInterests_users_ownerid",
                table: "placeOfInterests",
                column: "ownerid",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_shops_ShopId",
                table: "products",
                column: "ShopId",
                principalTable: "shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_placeOfInterests_users_ownerid",
                table: "placeOfInterests");

            migrationBuilder.DropForeignKey(
                name: "FK_products_shops_ShopId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops");

            migrationBuilder.DropForeignKey(
                name: "FK_userPlaceOfIntrests_users_UserId",
                table: "userPlaceOfIntrests");

            migrationBuilder.DropIndex(
                name: "IX_shops_PlaceId",
                table: "shops");

            migrationBuilder.DropIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "shops",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ownerid",
                table: "placeOfInterests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_shops_PlaceId",
                table: "shops",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_shops_UserId",
                table: "shops",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests",
                column: "ownerid");

            migrationBuilder.AddForeignKey(
                name: "FK_placeOfInterests_users_ownerid",
                table: "placeOfInterests",
                column: "ownerid",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_shops_ShopId",
                table: "products",
                column: "ShopId",
                principalTable: "shops",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_shops_placeOfInterests_PlaceId",
                table: "shops",
                column: "PlaceId",
                principalTable: "placeOfInterests",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_shops_users_UserId",
                table: "shops",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userPlaceOfIntrests_users_UserId",
                table: "userPlaceOfIntrests",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

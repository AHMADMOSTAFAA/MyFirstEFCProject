using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportify.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ownerfktoplaceofintrest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ownerid",
                table: "placeOfInterests",
                type: "int",
                nullable: true);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_placeOfInterests_users_ownerid",
                table: "placeOfInterests");

            migrationBuilder.DropIndex(
                name: "IX_placeOfInterests_ownerid",
                table: "placeOfInterests");

            migrationBuilder.DropColumn(
                name: "ownerid",
                table: "placeOfInterests");
        }
    }
}

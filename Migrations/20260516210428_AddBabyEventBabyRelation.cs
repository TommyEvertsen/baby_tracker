using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BabyTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddBabyEventBabyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BabyId",
                table: "BabyEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BabyEvents_BabyId",
                table: "BabyEvents",
                column: "BabyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BabyEvents_Babies_BabyId",
                table: "BabyEvents",
                column: "BabyId",
                principalTable: "Babies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BabyEvents_Babies_BabyId",
                table: "BabyEvents");

            migrationBuilder.DropIndex(
                name: "IX_BabyEvents_BabyId",
                table: "BabyEvents");

            migrationBuilder.DropColumn(
                name: "BabyId",
                table: "BabyEvents");
        }
    }
}

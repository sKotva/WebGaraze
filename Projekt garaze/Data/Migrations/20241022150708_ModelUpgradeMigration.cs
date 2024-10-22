using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_garaze.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpgradeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Garage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GarageId",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Garage_OwnerId",
                table: "Garage",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_GarageId",
                table: "Car",
                column: "GarageId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_OwnerId",
                table: "Car",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Garage_GarageId",
                table: "Car",
                column: "GarageId",
                principalTable: "Garage",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Owner_OwnerId",
                table: "Car",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Garage_Owner_OwnerId",
                table: "Garage",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Garage_GarageId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Owner_OwnerId",
                table: "Car");

            migrationBuilder.DropForeignKey(
                name: "FK_Garage_Owner_OwnerId",
                table: "Garage");

            migrationBuilder.DropIndex(
                name: "IX_Garage_OwnerId",
                table: "Garage");

            migrationBuilder.DropIndex(
                name: "IX_Car_GarageId",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_OwnerId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Garage");

            migrationBuilder.DropColumn(
                name: "GarageId",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Car");
        }
    }
}

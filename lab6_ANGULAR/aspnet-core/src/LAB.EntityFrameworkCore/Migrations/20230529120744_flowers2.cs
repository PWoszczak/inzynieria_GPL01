using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB.Migrations
{
    public partial class flowers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Flowers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "Flowers",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlowerID",
                table: "Bouquets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "FlowerId",
                table: "Bouquets",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flowers_UserId",
                table: "Flowers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bouquets_FlowerId",
                table: "Bouquets",
                column: "FlowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bouquets_Flowers_FlowerId",
                table: "Bouquets",
                column: "FlowerId",
                principalTable: "Flowers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Flowers_AbpUsers_UserId",
                table: "Flowers",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bouquets_Flowers_FlowerId",
                table: "Bouquets");

            migrationBuilder.DropForeignKey(
                name: "FK_Flowers_AbpUsers_UserId",
                table: "Flowers");

            migrationBuilder.DropIndex(
                name: "IX_Flowers_UserId",
                table: "Flowers");

            migrationBuilder.DropIndex(
                name: "IX_Bouquets_FlowerId",
                table: "Bouquets");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Flowers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Flowers");

            migrationBuilder.DropColumn(
                name: "FlowerID",
                table: "Bouquets");

            migrationBuilder.DropColumn(
                name: "FlowerId",
                table: "Bouquets");
        }
    }
}

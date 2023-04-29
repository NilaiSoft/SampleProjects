using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleProjects.Models.Migrations
{
    public partial class cityClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_StateProvinces_StateProvinceId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateProvinceId",
                table: "City",
                newName: "IX_City_StateProvinceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_City_StateProvinces_StateProvinceId",
                table: "City",
                column: "StateProvinceId",
                principalTable: "StateProvinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_StateProvinces_StateProvinceId",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_City_StateProvinceId",
                table: "Cities",
                newName: "IX_Cities_StateProvinceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_StateProvinces_StateProvinceId",
                table: "Cities",
                column: "StateProvinceId",
                principalTable: "StateProvinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

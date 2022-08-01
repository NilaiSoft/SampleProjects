using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleProjects.Models.Migrations
{
    public partial class adddescriptionrecordtocategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ClaimManageAPI.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MrefID",
                table: "Plans",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MrefID",
                table: "Plans");
        }
    }
}

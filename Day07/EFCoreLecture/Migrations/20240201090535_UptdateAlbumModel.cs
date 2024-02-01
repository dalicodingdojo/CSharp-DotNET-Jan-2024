using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreLecture.Migrations
{
    public partial class UptdateAlbumModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ChartedOnBillBoard",
                table: "Albums",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChartedOnBillBoard",
                table: "Albums");
        }
    }
}

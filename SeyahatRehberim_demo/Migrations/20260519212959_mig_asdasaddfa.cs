using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeyahatRehberim_demo.Migrations
{
    /// <inheritdoc />
    public partial class mig_asdasaddfa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestImage",
                table: "Destinations");
        }
    }
}

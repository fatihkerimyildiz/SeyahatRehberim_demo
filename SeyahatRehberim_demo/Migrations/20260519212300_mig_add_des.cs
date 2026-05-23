using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeyahatRehberim_demo.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_des : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestCost = table.Column<double>(type: "float", nullable: false),
                    DestDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeyahatRehberim_demo.Migrations
{
    /// <inheritdoc />
    public partial class mig_addasdadfasf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Comments",
                newName: "Blogid");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_BlogID",
                table: "Comments",
                newName: "IX_Comments_Blogid");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_Blogid",
                table: "Comments",
                column: "Blogid",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_Blogid",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "Blogid",
                table: "Comments",
                newName: "BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Blogid",
                table: "Comments",
                newName: "IX_Comments_BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogID",
                table: "Comments",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace pg.EntityFramework.Migrations
{
    public partial class ChangeColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Blogs",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Blogs",
                newName: "BlogId");
        }
    }
}

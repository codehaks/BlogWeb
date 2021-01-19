using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBlog.Migrations
{
    public partial class BlogPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "_Price",
                table: "Blogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_Price",
                table: "Blogs");
        }
    }
}

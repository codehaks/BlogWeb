using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBlog.Migrations
{
    public partial class BlogSe2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "blog_seq1");

            migrationBuilder.CreateSequence<int>(
                name: "seq2",
                startValue: 10L,
                incrementBy: 1000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "seq2");

            migrationBuilder.CreateSequence(
                name: "blog_seq1",
                incrementBy: 10);
        }
    }
}

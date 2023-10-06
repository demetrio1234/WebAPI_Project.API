using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_Project.API.Migrations {
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogItems",
                columns: table => new
                {
                    blog_item_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    blog_item_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blog_item_description_short = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blog_item_description_long = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blog_item_image_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blog_item_url_handle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blog_item_publish_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    blog_item_author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blog_item_isvisible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogItems", x => x.blog_item_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    category_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_url_handle = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogItems");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

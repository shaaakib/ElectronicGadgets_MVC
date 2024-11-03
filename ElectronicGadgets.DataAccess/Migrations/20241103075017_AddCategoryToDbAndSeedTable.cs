using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectronicGadgets.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToDbAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, "Mobile phones with advanced features", 1, "Smartphones" },
                    { 2, "Portable personal computers", 2, "Laptops" },
                    { 3, "Compact touchscreen devices", 3, "Tablets" },
                    { 4, "Wearable devices with smart features", 4, "Smartwatches" },
                    { 5, "Electronic devices for viewing multimedia content", 5, "Televisions" },
                    { 6, "Devices used to capture photographs or videos", 6, "Cameras" },
                    { 7, "Personal audio listening devices", 7, "Headphones" },
                    { 8, "Devices that amplify sound", 8, "Speakers" },
                    { 9, "Devices used to play video games", 9, "Gaming Consoles" },
                    { 10, "Electronic devices for visual display", 10, "Monitors" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

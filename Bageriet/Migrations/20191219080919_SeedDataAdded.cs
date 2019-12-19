using Microsoft.EntityFrameworkCore.Migrations;

namespace Bageriet.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ProductName" },
                values: new object[] { 1, "Nybakat bröd som passar lika bra till frukost som till lunch", "Bröd" });

            migrationBuilder.InsertData(
                table: "Bread",
                columns: new[] { "BreadId", "ImageUrl", "InStock", "LongDescription", "Name", "Price", "ProductId", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "/Images/bread1.jpg", true, "Rågbrödet med consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Rågbröd", 12.95m, 1, "Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis." },
                    { 2, "/Images/bread2.jpg", true, "Höstbrödet med consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Höstbröd", 11.95m, 1, "Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis." },
                    { 3, "/Images/bread3.jpg", true, "Fröbrödbrödet med consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Fröbröd", 13.95m, 1, "Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis." },
                    { 4, "/Images/bread4.jpg", true, "Baguetten med consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Baguette", 9.95m, 1, "Lorem ipsum dolor sit amet, consectem arcu, interdum vel accumsan vitae, lobortis." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "BreadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "BreadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "BreadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bread",
                keyColumn: "BreadId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);
        }
    }
}

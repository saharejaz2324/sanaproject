using Microsoft.EntityFrameworkCore.Migrations;

namespace customerService.Migrations
{
    public partial class seedproducttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Product_Id", "Product_Des", "Product_Name", "Product_Price", "Product_Tax" },
                values: new object[] { 1, "white sause", "pasta", 880f, 50f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_Id",
                keyValue: 1);
        }
    }
}

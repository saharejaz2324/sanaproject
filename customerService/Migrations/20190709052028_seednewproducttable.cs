using Microsoft.EntityFrameworkCore.Migrations;

namespace customerService.Migrations
{
    public partial class seednewproducttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_Id",
                keyValue: 1,
                column: "Product_Name",
                value: "Pasta");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Product_Id", "Product_Des", "Product_Name", "Product_Price", "Product_Tax" },
                values: new object[,]
                {
                    { 2, "grilled", "Chicken", 880f, 50f },
                    { 3, "labaniese sause", "Burger", 880f, 50f },
                    { 4, "chicken maushroom sause", "stake", 880f, 50f },
                    { 5, "BBQ", "pizza", 880f, 50f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Product_Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Product_Id",
                keyValue: 1,
                column: "Product_Name",
                value: "pasta");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeManagement.Infrastructure.Migrations
{
    public partial class DbAlter01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__Order_De__BAD83E694F10BB75",
                table: "Order_Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Ingredie__4F65EB26FD602222",
                table: "Ingredient_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Customer__4849DA002BEBA918",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Category__23CAF1F8D070963D",
                table: "Category_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Account__F3DBC5732C1D2179",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "Order_Detail");

            migrationBuilder.RenameIndex(
                name: "UQ__Staff__F3DBC5727E27AA2E",
                table: "Staff",
                newName: "UQ__Staff__F3DBC572B6D12225");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Order",
                newName: "createDate");

            migrationBuilder.AddColumn<double>(
                name: "amount",
                table: "Order",
                type: "float",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Order_De__BAD83E69FE346B8E",
                table: "Order_Detail",
                columns: new[] { "orderID", "productID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Ingredie__4F65EB26F2FF0102",
                table: "Ingredient_Product",
                columns: new[] { "productID", "ingredientID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Customer__4849DA0085BD685F",
                table: "Customer",
                column: "phoneNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Category__23CAF1F824033D21",
                table: "Category_Product",
                column: "categoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Account__F3DBC573F661B42D",
                table: "Account",
                column: "username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__Order_De__BAD83E69FE346B8E",
                table: "Order_Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Ingredie__4F65EB26F2FF0102",
                table: "Ingredient_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Customer__4849DA0085BD685F",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Category__23CAF1F824033D21",
                table: "Category_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Account__F3DBC573F661B42D",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "amount",
                table: "Order");

            migrationBuilder.RenameIndex(
                name: "UQ__Staff__F3DBC572B6D12225",
                table: "Staff",
                newName: "UQ__Staff__F3DBC5727E27AA2E");

            migrationBuilder.RenameColumn(
                name: "createDate",
                table: "Order",
                newName: "productID");

            migrationBuilder.AddColumn<double>(
                name: "totalPrice",
                table: "Order_Detail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Order_De__BAD83E694F10BB75",
                table: "Order_Detail",
                columns: new[] { "orderID", "productID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Ingredie__4F65EB26FD602222",
                table: "Ingredient_Product",
                columns: new[] { "productID", "ingredientID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Customer__4849DA002BEBA918",
                table: "Customer",
                column: "phoneNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Category__23CAF1F8D070963D",
                table: "Category_Product",
                column: "categoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Account__F3DBC5732C1D2179",
                table: "Account",
                column: "username");
        }
    }
}

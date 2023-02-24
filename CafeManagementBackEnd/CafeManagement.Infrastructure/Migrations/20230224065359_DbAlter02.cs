using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeManagement.Infrastructure.Migrations
{
    public partial class DbAlter02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "status",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "Order");

            migrationBuilder.RenameIndex(
                name: "UQ__Staff__F3DBC572B6D12225",
                table: "Staff",
                newName: "UQ__Staff__F3DBC572DD48F397");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Product",
                newName: "productName");

            migrationBuilder.AddColumn<double>(
                name: "salary",
                table: "Staff",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "totalPrice",
                table: "Order_Detail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "dateOrder",
                table: "Order",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Customer",
                type: "char(1)",
                unicode: false,
                fixedLength: true,
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Order_De__BAD83E69228683BE",
                table: "Order_Detail",
                columns: new[] { "orderID", "productID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Ingredie__4F65EB2601D4E7FD",
                table: "Ingredient_Product",
                columns: new[] { "productID", "ingredientID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK__Customer__4849DA006E08C1C1",
                table: "Customer",
                column: "phoneNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Category__23CAF1F82C89AA82",
                table: "Category_Product",
                column: "categoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Account__F3DBC573CC67DD41",
                table: "Account",
                column: "username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__Order_De__BAD83E69228683BE",
                table: "Order_Detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Ingredie__4F65EB2601D4E7FD",
                table: "Ingredient_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Customer__4849DA006E08C1C1",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Category__23CAF1F82C89AA82",
                table: "Category_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Account__F3DBC573CC67DD41",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "salary",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "Order_Detail");

            migrationBuilder.DropColumn(
                name: "dateOrder",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Customer");

            migrationBuilder.RenameIndex(
                name: "UQ__Staff__F3DBC572DD48F397",
                table: "Staff",
                newName: "UQ__Staff__F3DBC572B6D12225");

            migrationBuilder.RenameColumn(
                name: "productName",
                table: "Product",
                newName: "name");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "Order",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}

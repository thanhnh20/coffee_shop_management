using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeManagement.Infrastructure.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category_Product",
                columns: table => new
                {
                    categoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Category__23CAF1F8D070963D", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    phoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Customer__4849DA002BEBA918", x => x.phoneNumber);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    ingredientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    unit = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.ingredientID);
                });

            migrationBuilder.CreateTable(
                name: "Payment_Method",
                columns: table => new
                {
                    paymentMethodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment_Method", x => x.paymentMethodID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    roleID = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.roleID);
                });

            migrationBuilder.CreateTable(
                name: "Status_Order",
                columns: table => new
                {
                    statusOrderID = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status_Order", x => x.statusOrderID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    price = table.Column<double>(type: "float", nullable: true),
                    image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    categoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.productID);
                    table.ForeignKey(
                        name: "FK_CATEGORYID_PRODUCT",
                        column: x => x.categoryID,
                        principalTable: "Category_Product",
                        principalColumn: "categoryID");
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    storageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ingredientID = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.storageID);
                    table.ForeignKey(
                        name: "FK_INGREDIENT_ID_STORAGE",
                        column: x => x.ingredientID,
                        principalTable: "Ingredient",
                        principalColumn: "ingredientID");
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    roleID = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Account__F3DBC5732C1D2179", x => x.username);
                    table.ForeignKey(
                        name: "FK_ROLEID_ACCOUNT",
                        column: x => x.roleID,
                        principalTable: "Role",
                        principalColumn: "roleID");
                });

            migrationBuilder.CreateTable(
                name: "Ingredient_Product",
                columns: table => new
                {
                    productID = table.Column<int>(type: "int", nullable: false),
                    ingredientID = table.Column<int>(type: "int", nullable: false),
                    mass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ingredie__4F65EB26FD602222", x => new { x.productID, x.ingredientID });
                    table.ForeignKey(
                        name: "FK_INGREDIENT_ID_INGREDIENT_PRODUCT",
                        column: x => x.ingredientID,
                        principalTable: "Ingredient",
                        principalColumn: "ingredientID");
                    table.ForeignKey(
                        name: "FK_PRODUCT_ID_INGREDIENT_PRODUCT",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "productID");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    staffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    dateJoin = table.Column<DateTime>(type: "date", nullable: false),
                    address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    phoneNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    dateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    taxCode = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.staffID);
                    table.ForeignKey(
                        name: "FK_USERNAME_STAFF",
                        column: x => x.username,
                        principalTable: "Account",
                        principalColumn: "username");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    orderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<DateTime>(type: "date", nullable: false),
                    staffID = table.Column<int>(type: "int", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    paymentMethodID = table.Column<int>(type: "int", nullable: false),
                    statusOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.orderID);
                    table.ForeignKey(
                        name: "FK_PAYMENT_METHOD_ID_ORDERR",
                        column: x => x.paymentMethodID,
                        principalTable: "Payment_Method",
                        principalColumn: "paymentMethodID");
                    table.ForeignKey(
                        name: "FK_PHONENUMBER_ORDER",
                        column: x => x.phoneNumber,
                        principalTable: "Customer",
                        principalColumn: "phoneNumber");
                    table.ForeignKey(
                        name: "FK_STAFFID_ORDERR",
                        column: x => x.staffID,
                        principalTable: "Staff",
                        principalColumn: "staffID");
                    table.ForeignKey(
                        name: "FK_STATUS_ORDER_ID_ORDERR",
                        column: x => x.statusOrderID,
                        principalTable: "Status_Order",
                        principalColumn: "statusOrderID");
                });

            migrationBuilder.CreateTable(
                name: "Order_Detail",
                columns: table => new
                {
                    orderID = table.Column<int>(type: "int", nullable: false),
                    productID = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    totalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Order_De__BAD83E694F10BB75", x => new { x.orderID, x.productID });
                    table.ForeignKey(
                        name: "FK_ORDER_ID_ORDER_DETAIL",
                        column: x => x.orderID,
                        principalTable: "Order",
                        principalColumn: "orderID");
                    table.ForeignKey(
                        name: "FK_PRODUCT_ID_ORDER_DETAIL",
                        column: x => x.productID,
                        principalTable: "Product",
                        principalColumn: "productID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_roleID",
                table: "Account",
                column: "roleID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_Product_ingredientID",
                table: "Ingredient_Product",
                column: "ingredientID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_paymentMethodID",
                table: "Order",
                column: "paymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_phoneNumber",
                table: "Order",
                column: "phoneNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Order_staffID",
                table: "Order",
                column: "staffID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_statusOrderID",
                table: "Order",
                column: "statusOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Detail_productID",
                table: "Order_Detail",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_categoryID",
                table: "Product",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "UQ__Staff__F3DBC5727E27AA2E",
                table: "Staff",
                column: "username",
                unique: true,
                filter: "[username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_ingredientID",
                table: "Storage",
                column: "ingredientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredient_Product");

            migrationBuilder.DropTable(
                name: "Order_Detail");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Payment_Method");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Status_Order");

            migrationBuilder.DropTable(
                name: "Category_Product");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}

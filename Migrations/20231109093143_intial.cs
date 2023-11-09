using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreModel.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "promotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vendor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promotion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    ZipCode = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    Telephone = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Storeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_orders_stores_Storeid",
                        column: x => x.Storeid,
                        principalTable: "stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordersLine",
                columns: table => new
                {
                    orderID = table.Column<int>(type: "int", nullable: false),
                    itemId = table.Column<int>(type: "int", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordersLine", x => x.orderID);
                    table.ForeignKey(
                        name: "FK_ordersLine_items_itemId",
                        column: x => x.itemId,
                        principalTable: "items",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordersLine_orders_orderID",
                        column: x => x.orderID,
                        principalTable: "orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordersLine_promotion_PromotionId",
                        column: x => x.PromotionId,
                        principalTable: "promotion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "items",
                columns: new[] { "ID", "VendorName", "description", "price" },
                values: new object[,]
                {
                    { 1, "yasin ahmed", "shipsy", 12.3m },
                    { 2, "ali ahmed", "pipc", 225.3m }
                });

            migrationBuilder.InsertData(
                table: "promotion",
                columns: new[] { "Id", "vendor" },
                values: new object[,]
                {
                    { 1, "mohmed Hamdi" },
                    { 2, "mohmed Hamdi" }
                });

            migrationBuilder.InsertData(
                table: "stores",
                columns: new[] { "id", "City", "State", "Telephone", "ZipCode", "name" },
                values: new object[,]
                {
                    { 1, "cairo", "Egypt", "0822501274", "082", "CairoStore" },
                    { 2, "Benisue", "Egypt", "0722551264", "072", "BenisuefStore" }
                });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "OrderId", "Storeid" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ordersLine",
                columns: new[] { "orderID", "PromotionId", "itemId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_Storeid",
                table: "orders",
                column: "Storeid");

            migrationBuilder.CreateIndex(
                name: "IX_ordersLine_itemId",
                table: "ordersLine",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_ordersLine_PromotionId",
                table: "ordersLine",
                column: "PromotionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ordersLine");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "promotion");

            migrationBuilder.DropTable(
                name: "stores");
        }
    }
}

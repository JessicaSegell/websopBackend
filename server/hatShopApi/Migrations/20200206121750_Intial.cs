using Microsoft.EntityFrameworkCore.Migrations;

namespace hatShopApi.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    imgStr = table.Column<string>(nullable: true),
                    hatName = table.Column<string>(nullable: true),
                    hatPrice = table.Column<int>(nullable: false),
                    hatText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Total = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    HatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Hats_HatId",
                        column: x => x.HatId,
                        principalTable: "Hats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_OrderItems_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderItems",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hats",
                columns: new[] { "Id", "hatName", "hatPrice", "hatText", "imgStr" },
                values: new object[] { 1, "Hatt(1)", 100, "Lorem ipsum", "" });

            migrationBuilder.InsertData(
                table: "Hats",
                columns: new[] { "Id", "hatName", "hatPrice", "hatText", "imgStr" },
                values: new object[] { 2, "Hatt(1)", 100, "Lorem ipsum", "" });

            migrationBuilder.InsertData(
                table: "Hats",
                columns: new[] { "Id", "hatName", "hatPrice", "hatText", "imgStr" },
                values: new object[] { 3, "Hatt(1)", 100, "Lorem ipsum", "" });

            migrationBuilder.InsertData(
                table: "Hats",
                columns: new[] { "Id", "hatName", "hatPrice", "hatText", "imgStr" },
                values: new object[] { 4, "Hatt(1)", 100, "Lorem ipsum", "" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_HatId",
                table: "ShoppingCartItems",
                column: "HatId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_OrderId",
                table: "ShoppingCartItems",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Hats");

            migrationBuilder.DropTable(
                name: "OrderItems");
        }
    }
}

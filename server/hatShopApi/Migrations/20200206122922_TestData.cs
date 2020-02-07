using Microsoft.EntityFrameworkCore.Migrations;

namespace hatShopApi.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "hatName", "hatText", "imgStr" },
                values: new object[] { "Hashtag Hat", "Keep warm while tweeting", "http://t0.gstatic.com/images?q=tbn%3AANd9GcRvO9UDf-3_pYJ8-krePNKiwm-D73OtdZan9ETILEIDwlQO18VxvZQgGZlaex4&usqp=CAc" });

            migrationBuilder.UpdateData(
                table: "Hats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "hatName", "hatText", "imgStr" },
                values: new object[] { "200", "Let people know you are OK", "http://t0.gstatic.com/images?q=tbn%3AANd9GcTBv6cqMX7yBTcT_GKOTFVLlx1QZd2oUYz4kVPzS6Y8_sWvKqOi14SfCbBiq00dlsE40jxh2yY&usqp=CAc" });

            migrationBuilder.UpdateData(
                table: "Hats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "hatName", "hatText", "imgStr" },
                values: new object[] { "new MyHat()", "This is an instance of a hat", "http://t0.gstatic.com/images?q=tbn%3AANd9GcQgqMJlq9uu9m9EVmm5ytER2-h68fXvFkBwdrjxwVMFzOY4v713l-VZVTsLPS8aS43O9TXkzsq-&usqp=CAc" });

            migrationBuilder.UpdateData(
                table: "Hats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "hatName", "hatText", "imgStr" },
                values: new object[] { "I Am Hat", "This hat is self aware", "http://t0.gstatic.com/images?q=tbn%3AANd9GcT8zZNXpCSXXRFd8bF5ED2jwQv6Iym_SExvExyBppUlv0574IMMSG9SRg3l3bA_P6Z774FE5e4P&usqp=CAc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "hatName", "hatText", "imgStr" },
                values: new object[] { "Hatt(1)", "Lorem ipsum", "" });

            migrationBuilder.UpdateData(
                table: "Hats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "hatName", "hatText", "imgStr" },
                values: new object[] { "Hatt(1)", "Lorem ipsum", "" });

            migrationBuilder.UpdateData(
                table: "Hats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "hatName", "hatText", "imgStr" },
                values: new object[] { "Hatt(1)", "Lorem ipsum", "" });

            migrationBuilder.UpdateData(
                table: "Hats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "hatName", "hatText", "imgStr" },
                values: new object[] { "Hatt(1)", "Lorem ipsum", "" });
        }
    }
}

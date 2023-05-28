using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SensorTracker.DataAcessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sensors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SensorId = table.Column<int>(type: "int", nullable: true),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Sensors_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensors",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "С засыпкой", "K1", 52.0 },
                    { 2, "С засыпкой", "К1У", 52.0 },
                    { 3, "С засыпкой", "K2", 52.0 },
                    { 4, "С засыпкой", "K2-KP", 52.0 },
                    { 5, "С засыпкой", "K2.1", 52.0 },
                    { 6, "С засыпкой", "K2T", 52.0 },
                    { 7, "С засыпкой", "К2Ф", 52.0 },
                    { 9, "С засыпкой", "K3", 52.0 },
                    { 10, "С засыпкой", "K4", 52.0 },
                    { 11, "С засыпкой", "K4P", 52.0 },
                    { 12, "С засыпкой", "K4.1", 52.0 },
                    { 13, "С засыпкой", "K5", 52.0 },
                    { 14, "С засыпкой", "К1И", 52.0 },
                    { 15, "С засыпкой", "ТКЖ", 52.0 },
                    { 16, "С засыпкой", "IT-8 RUT", 52.0 },
                    { 17, null, "K1", 37.0 },
                    { 18, null, "K2", 37.0 },
                    { 19, null, "K2.1", 37.0 },
                    { 20, null, "K3", 37.0 },
                    { 21, null, "K4", 37.0 },
                    { 22, null, "K5", 37.0 },
                    { 23, null, "K2Ф", 37.0 },
                    { 24, null, "K2М", 37.0 },
                    { 25, null, "K0", 45.0 },
                    { 26, null, "K9", 58.0 },
                    { 27, null, "K10", 45.0 },
                    { 28, null, "K1И-КП", 52.0 },
                    { 29, null, "", 52.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SensorId",
                table: "Orders",
                column: "SensorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Sensors");
        }
    }
}

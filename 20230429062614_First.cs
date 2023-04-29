using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaApi.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "qwertyu", new DateTime(2023, 4, 29, 11, 56, 14, 690, DateTimeKind.Local).AddTicks(4919), "awsedrtfuikolkmj dxujhsgfgvbhkm rdgyuhijogf", "https://dotnetmastery.com/bluevillaimages/villa3.jpg", "abc Villa", 7, 2000.0, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "oiuyt", new DateTime(2023, 4, 29, 11, 56, 14, 690, DateTimeKind.Local).AddTicks(4934), "sedrftgyhuj oiujytdrf poiuytrsdcfgvhbjnmk ftgyuhj", "https://dotnetmastery.com/bluevillaimages/villa1.jpg", "def Villa", 9, 1500.0, 2500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "fghkj", new DateTime(2023, 4, 29, 11, 56, 14, 690, DateTimeKind.Local).AddTicks(4936), "wertyuhj lkjhgfd poiuytrdsx kjhgfd", "https://dotnetmastery.com/bluevillaimages/villa4.jpg", "qwe Villa", 3, 400.0, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "dfgjhgjh", new DateTime(2023, 4, 29, 11, 56, 14, 690, DateTimeKind.Local).AddTicks(4938), "sdfgkjhgfd iuytrdf sdfyujk lokjhgfd", "https://dotnetmastery.com/bluevillaimages/villa5.jpg", "poi Villa", 4, 500.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "ertyui", new DateTime(2023, 4, 29, 11, 56, 14, 690, DateTimeKind.Local).AddTicks(4939), "qwertyuiolkj sdfghjkl lkiuytredxcvbnm sdfghjkkkmnbvcd", "https://dotnetmastery.com/bluevillaimages/villa2.jpg", "mnb Villa", 5, 800.0, 1200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}

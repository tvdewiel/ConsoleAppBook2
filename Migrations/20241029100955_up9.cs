using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppBook2.Migrations
{
    /// <inheritdoc />
    public partial class up9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceOffer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewPrice = table.Column<double>(type: "float", nullable: false),
                    PromoText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookISBN = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceOffer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceOffer_BookInfo_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "BookInfo",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookInfo_Title",
                table: "BookInfo",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_PriceOffer_BookISBN",
                table: "PriceOffer",
                column: "BookISBN",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceOffer");

            migrationBuilder.DropIndex(
                name: "IX_BookInfo_Title",
                table: "BookInfo");
        }
    }
}

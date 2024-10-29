using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppBook2.Migrations
{
    /// <inheritdoc />
    public partial class up7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_PublisherInfo_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "BookInfo");

            migrationBuilder.RenameIndex(
                name: "IX_Books_PublisherId",
                table: "BookInfo",
                newName: "IX_BookInfo_PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookInfo",
                table: "BookInfo",
                column: "ISBN");

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    BookISBN = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_BookInfo_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "BookInfo",
                        principalColumn: "ISBN");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_BookISBN",
                table: "Review",
                column: "BookISBN");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInfo_PublisherInfo_PublisherId",
                table: "BookInfo",
                column: "PublisherId",
                principalTable: "PublisherInfo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInfo_PublisherInfo_PublisherId",
                table: "BookInfo");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookInfo",
                table: "BookInfo");

            migrationBuilder.RenameTable(
                name: "BookInfo",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_BookInfo_PublisherId",
                table: "Books",
                newName: "IX_Books_PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "ISBN");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_PublisherInfo_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "PublisherInfo",
                principalColumn: "Id");
        }
    }
}

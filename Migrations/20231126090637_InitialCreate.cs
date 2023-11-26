using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LINQToQuery.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GenreId = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstName", "LastName", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6882), null, "Michelle", "Alexander", 1, null },
                    { 2, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6885), null, "Stephen E.", "Ambrose", 1, null },
                    { 3, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6886), null, "Margaret", "Atwood", 1, null },
                    { 4, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6887), null, "Jane", "Austen", 1, null },
                    { 5, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6888), null, "James", "Baldwin", 1, null },
                    { 6, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6889), null, "Emily", "Bronte", 1, null },
                    { 7, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6890), null, "Agatha", "Christie", 1, null },
                    { 8, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6891), null, "Ta-Nehisi", "Coates", 1, null },
                    { 9, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6892), null, "Jared", "Diamond", 1, null },
                    { 10, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6893), null, "Joa", "Didion", 1, null },
                    { 11, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6894), null, "Daphne", "Du Maurier", 1, null },
                    { 12, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6895), null, "Tina", "Fey", 1, null },
                    { 13, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6896), null, "Roxane", "Gay", 1, null },
                    { 14, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6897), null, "Dashiel", "Hammett", 1, null },
                    { 15, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6898), null, "Frank", "Herbert", 1, null },
                    { 16, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6899), null, "Aldous", "Huxley", 1, null },
                    { 17, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6900), null, "Stieg", "Larsson", 1, null },
                    { 18, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6901), null, "David", "McCullogh", 1, null },
                    { 19, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6902), null, "Toni", "Morrison", 1, null },
                    { 20, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6903), null, "George", "Orwell", 1, null },
                    { 21, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6904), null, "Mary", "Shelley", 1, null },
                    { 22, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6904), null, "Sun", "Tzu", 1, null },
                    { 23, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6905), null, "Augusten", "Burroughs", 1, null },
                    { 25, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6907), null, "JK", "Rowling", 1, null },
                    { 26, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6908), null, "Seth", "Grahame-Smith", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { "history", new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6133), null, "History", 1, null },
                    { "memoir", new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6130), null, "Memoir", 1, null },
                    { "mystery", new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6131), null, "Mystery", 1, null },
                    { "novel", new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6118), null, "Novel", 1, null },
                    { "scifi", new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6132), null, "Science Finction", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "GenreId", "Price", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6515), null, "history", 18.0, 1, "1776", null },
                    { 2, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6519), null, "scifi", 5.5, 1, "1984", null },
                    { 3, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6521), null, "mystery", 4.5, 1, "And Then There Were None", null },
                    { 4, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6522), null, "history", 11.5, 1, "Band of Brothers", null },
                    { 5, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6523), null, "novel", 10.99, 1, "Beloved", null },
                    { 6, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6525), null, "memoir", 13.5, 1, "Between The World And Me", null },
                    { 7, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6526), null, "memoir", 4.25, 1, "Bossypants", null },
                    { 8, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6566), null, "scifi", 16.25, 1, "Brave New World", null },
                    { 9, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6567), null, "history", 15.0, 1, "D-Day", null },
                    { 10, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6569), null, "memoir", 4.25, 1, "Down and Out in Paris and London", null },
                    { 11, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6570), null, "scifi", 8.75, 1, "Dune", null },
                    { 12, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6571), null, "novel", 9.0, 1, "Emma", null },
                    { 13, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6572), null, "scifi", 6.5, 1, "Frankestein", null },
                    { 14, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6573), null, "novel", 10.25, 1, "Go Tell It On The Mountain", null },
                    { 15, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6574), null, "history", 15.5, 1, "Guns, Germs and Steel", null },
                    { 16, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6575), null, "memoir", 14.5, 1, "Hunger", null },
                    { 17, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6576), null, "mystery", 6.75, 1, "Murder on the Orient Express", null },
                    { 18, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6577), null, "novel", 8.5, 1, "Pride and Prejudice", null },
                    { 19, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6578), null, "mystery", 10.99, 1, "Rebecca", null },
                    { 20, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6580), null, "history", 5.75, 1, "The Art of War", null },
                    { 21, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6581), null, "mystery", 8.5, 1, "The Girl With The Dragon Tattoo", null },
                    { 22, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6582), null, "scifi", 12.5, 1, "The Handmaid's Tale", null },
                    { 23, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6583), null, "mystery", 10.99, 1, "The Maltese Falcon", null },
                    { 24, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6584), null, "history", 13.75, 1, "The New Jim Crow", null },
                    { 25, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6585), null, "memoir", 13.5, 1, "The Year of Magical Thinking", null },
                    { 26, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6586), null, "novel", 9.0, 1, "Wuthering Heights", null },
                    { 27, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6587), null, "memoir", 11.0, 1, "Running With Scissors", null },
                    { 28, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6588), null, "novel", 8.75, 1, "Pride and Prejudice and Zombies", null },
                    { 29, new DateTime(2023, 11, 26, 12, 6, 37, 174, DateTimeKind.Local).AddTicks(6589), null, "novel", 9.75, 1, "Harry Potter and The Sorcerer's Stone", null }
                });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 24 },
                    { 2, 4 },
                    { 2, 9 },
                    { 3, 22 },
                    { 4, 12 },
                    { 4, 18 },
                    { 4, 28 },
                    { 5, 14 },
                    { 6, 26 },
                    { 7, 3 },
                    { 7, 17 },
                    { 8, 6 },
                    { 9, 15 },
                    { 10, 25 },
                    { 11, 19 },
                    { 12, 7 },
                    { 13, 16 },
                    { 14, 23 },
                    { 15, 11 },
                    { 16, 8 },
                    { 17, 21 },
                    { 18, 1 },
                    { 19, 5 },
                    { 20, 2 },
                    { 20, 10 },
                    { 21, 13 },
                    { 22, 20 },
                    { 23, 27 },
                    { 25, 29 },
                    { 26, 28 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}

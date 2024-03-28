using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameLoanedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksLoand");

            migrationBuilder.CreateTable(
                name: "BooksLoaned",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    DateBorrowed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateReturned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksLoaned", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooksLoaned_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksLoaned_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d77a659f-41c3-4872-9a3c-3a64b01625f1", "AQAAAAIAAYagAAAAEOdDUHcuM9r1KuDqwr42WNcKyUHyU/V7Z1DYcKbgr/3NWFNj7CweCNdgcP1SetDSVQ==", "c7b936c2-7e4f-46fe-96f2-c649f7b8f8dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d063b14e-23cc-4017-a6b2-41255b3fa5e9", "AQAAAAIAAYagAAAAEBJLjqhU8lFC5+7B6UQEZf1XfSMZGysSTWYpKw3NMgoagrRQEtUc4PcE54VUaFmVEA==", "3f42ac85-8ffd-4f33-9599-8e1fe4a05497" });

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2856), new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2868), new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2905), new DateTime(2024, 3, 28, 15, 52, 33, 697, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.CreateIndex(
                name: "IX_BooksLoaned_BookId",
                table: "BooksLoaned",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksLoaned_CustomerId",
                table: "BooksLoaned",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksLoaned");

            migrationBuilder.CreateTable(
                name: "BooksLoand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBorrowed = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateReturned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksLoand", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BooksLoand_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksLoand_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e50ae3ba-1adf-4ed9-81d0-fed5d6944b74", "AQAAAAIAAYagAAAAEAYc3UIJamvc7Mc5+mOI1OuL3lgJ2SG+uZxkoUivTRdxnR1JWU7znKBvLeYMEz1Ysw==", "bfc37149-971d-4ccd-a261-896ad8a7f2df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16ccadc5-c125-4b11-b54d-d73b2d7f3b82", "AQAAAAIAAYagAAAAEFT89QamduJlS6X4a0WVAuVURHqKpQTAdSksNLoAb8kbN0GsC0H98gldC5hnOwnNTg==", "6d01c5d9-efa3-4e4d-a9f2-e696d0e281bc" });

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5190), new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5197), new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5201), new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.CreateIndex(
                name: "IX_BooksLoand_BookId",
                table: "BooksLoand",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksLoand_CustomerId",
                table: "BooksLoand",
                column: "CustomerId");
        }
    }
}

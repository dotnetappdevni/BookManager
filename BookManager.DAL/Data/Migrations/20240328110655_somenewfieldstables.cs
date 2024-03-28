using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class somenewfieldstables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "BookInventories");

            migrationBuilder.DropColumn(
                name: "DateCheckedOut",
                table: "BookInventories");

            migrationBuilder.DropColumn(
                name: "IsOverDue",
                table: "BookInventories");

            migrationBuilder.CreateTable(
                name: "BooksLoand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
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
                values: new object[] { "d48f9510-b442-4eba-8fcd-1b6e96ca66f0", "AQAAAAIAAYagAAAAEDPi40c64zRwZcHU6P3UlO1RrbUFoFl12zVcKi/gjtRUrKL/A8lqbwRKaHgvkRKhxg==", "166cf532-74e7-43b3-b1e4-ec91ddf5e5ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6af1bc26-fa92-4883-adf7-5ed0fa534bb9", "AQAAAAIAAYagAAAAEIXt+KrKuWxnJ5GiuvkxEziivb2MdxG5nUa3Dnevzr+6z+vvvvuOLbclms/BvcTKdQ==", "179872a8-8348-48f8-a6c9-e48cbb63724f" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6313), new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6374), new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6375) });

            migrationBuilder.CreateIndex(
                name: "IX_BooksLoand_BookId",
                table: "BooksLoand",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksLoand_CustomerId",
                table: "BooksLoand",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksLoand");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "BookInventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCheckedOut",
                table: "BookInventories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOverDue",
                table: "BookInventories",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "375af7c9-c524-4fdb-844f-d6dd9cfb09bc", "AQAAAAIAAYagAAAAEHoPWbJmzxkXRqV930qMtKUoKM+RL4Shd6ZbsDx1XfCqipoi7wDyRcYPS2UPSUadHg==", "b51b883f-c462-4f2f-8ca7-7273fc0b476a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1daa0f06-3f97-4a9c-a0a7-ac5158783f89", "AQAAAAIAAYagAAAAEFzk/YrpNi5s2+Wmw8LtS2/T3vs0XAToC+0S8gfn8uCwBiHmRT2JswrvfhNrHEdyqg==", "2ea559a8-4b36-40fe-92c1-311b359d59fe" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9313), new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9317), new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9318) });
        }
    }
}

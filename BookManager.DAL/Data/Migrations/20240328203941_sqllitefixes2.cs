using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class sqllitefixes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksLoaned_Books_BookId",
                table: "BooksLoaned");

            migrationBuilder.DropIndex(
                name: "IX_BooksLoaned_BookId",
                table: "BooksLoaned");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "280d12a7-da83-45c0-b2b0-3a53149f0a87", "AQAAAAIAAYagAAAAEJibgknsEc5hRZMxNehkoCloaW++tLmAp9+9cykvc+TBve0Sag/DMUawQli1eFQUqQ==", "5c450297-a17c-4283-a6bf-4d86092e4b3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8a3b3a1-22a9-4180-986b-13d27cee247e", "AQAAAAIAAYagAAAAEKRZkAXnf9PNtrbKzoylqzgsCf1ozj8mngeoseB109IYFGTayQgQZ/ILC229N4kvxA==", "6d3354b5-0a3b-48d0-a06e-a8cb85be4a53" });

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(5999), new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(6006), new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(6010), new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(6011) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99e33435-8542-47aa-b3ac-0aa73e8d2df2", "AQAAAAIAAYagAAAAEO2ci5apV4KcXjFjfhjX9y1CLgY0y3Ss4+dDZ8Ynpqn4r2PcQk9Gq2+kK8PcgU8qPA==", "27725603-f928-4069-96a0-2aeaeb4bdac7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f42d461b-6d55-49eb-8051-bff6e826a169", "AQAAAAIAAYagAAAAEAf2bE/0gRmb++Y6mJdCPSMSVZ6sk7mwdvhYK3hsN55+Q+HPsCmyZx8CqH1U4l/k2w==", "7f96a941-db26-445d-b859-ec14bae9c49c" });

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 3, 28, 20, 36, 48, 243, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.CreateIndex(
                name: "IX_BooksLoaned_BookId",
                table: "BooksLoaned",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksLoaned_Books_BookId",
                table: "BooksLoaned",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

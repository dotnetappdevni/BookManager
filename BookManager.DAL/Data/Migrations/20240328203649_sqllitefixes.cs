using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class sqllitefixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksLoaned_Customers_CustomerId",
                table: "BooksLoaned");

            migrationBuilder.DropIndex(
                name: "IX_BooksLoaned_CustomerId",
                table: "BooksLoaned");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a48b982b-4434-4a2f-b42b-abe0d162ca46", "AQAAAAIAAYagAAAAEOlSPlBQ55gyaBNZgc5QSDiC81gp7VmKG90YbeqNSb4nHLiXf4UeTdIEDXOa8/YKEw==", "abe5dcbf-6e3f-47a8-8f92-53e481e90736" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "133aab6f-816c-4d5d-a4c4-40dcc36c5f17", "AQAAAAIAAYagAAAAELWrfyfeYlk/jYk6CTc0s527IFJ+JQmMeJjWh3ARfJb8eZebhJ3cDGIpMdiOHkTGUw==", "bc641975-4a33-4051-b251-6230855c21ff" });

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(259), new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(276), new DateTime(2024, 3, 28, 16, 1, 28, 971, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.CreateIndex(
                name: "IX_BooksLoaned_CustomerId",
                table: "BooksLoaned",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksLoaned_Customers_CustomerId",
                table: "BooksLoaned",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

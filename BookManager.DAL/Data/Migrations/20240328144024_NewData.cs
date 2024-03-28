using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "BookInventories",
                columns: new[] { "Id", "BarCode", "BookId", "DateCreated", "DateDeleted", "DateModified", "InventoryCount", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "1111", 3, new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5092), null, null, 10, true, false },
                    { 2, "3333", 4, new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5156), null, null, 5, true, false },
                    { 3, "4444", 5, new DateTime(2024, 3, 28, 14, 40, 23, 41, DateTimeKind.Local).AddTicks(5168), null, null, 9, true, false }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e397cf06-e7b7-4701-a4e4-5d9db762623c", "AQAAAAIAAYagAAAAENLfJGn3m8dH6QwJFvDkXuEbSgceQLCj+hn6yqWmQf4znPtkudnCiw2Qu4YD2vKKOQ==", "4b5e5179-a8eb-48ce-b967-28a628d116e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d267b49-01d8-404d-80db-7fe79f62809e", "AQAAAAIAAYagAAAAEHnUXeUcW27twX7TK4FxareWyFO0rKyXK7W3ku0aXAq83ixmQba5hL127RMWT6VgDw==", "cf444933-312a-4045-9121-a34ed9440545" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 35, 58, 930, DateTimeKind.Local).AddTicks(9225), new DateTime(2024, 3, 28, 11, 35, 58, 930, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 35, 58, 930, DateTimeKind.Local).AddTicks(9282), new DateTime(2024, 3, 28, 11, 35, 58, 930, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 35, 58, 930, DateTimeKind.Local).AddTicks(9286), new DateTime(2024, 3, 28, 11, 35, 58, 930, DateTimeKind.Local).AddTicks(9287) });
        }
    }
}

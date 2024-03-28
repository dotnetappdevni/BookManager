using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class sqllitefixes3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cebe0f0-14f6-4037-aa12-47cf459927a6", "AQAAAAIAAYagAAAAENkcBOPJSoLo+uG6OEU/bvl5ACC5brnk+UoWAsVxTTymYJi7sOWXEQv9Y4/l5Yc6rg==", "c025b1b3-dcdb-41e0-805f-2507a485e34c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed017189-a950-4f86-8e4f-e97b50bbcdd5", "AQAAAAIAAYagAAAAENhoNVRx/miX81uiEDODezb47l/WuI28tN0ObX1HjvqwD4xQwqTyvEC28dvyAq1qkQ==", "9fa63bae-76b1-48df-9ae6-2a0aecd6383c" });

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BarCode", "BookId", "DateCreated", "InventoryCount" },
                values: new object[] { "1111", 3, new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6629), 10 });

            migrationBuilder.InsertData(
                table: "BookInventories",
                columns: new[] { "Id", "BarCode", "BookId", "DateCreated", "DateDeleted", "DateModified", "InventoryCount", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 4, "3333", 4, new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6689), null, null, 5, true, false },
                    { 5, "4444", 5, new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6700), null, null, 9, true, false }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6723), new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6731), new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6735), new DateTime(2024, 3, 28, 20, 45, 35, 329, DateTimeKind.Local).AddTicks(6736) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 5);

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
                keyValue: 3,
                columns: new[] { "BarCode", "BookId", "DateCreated", "InventoryCount" },
                values: new object[] { "4444", 5, new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(5978), 9 });

            migrationBuilder.InsertData(
                table: "BookInventories",
                columns: new[] { "Id", "BarCode", "BookId", "DateCreated", "DateDeleted", "DateModified", "InventoryCount", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, "1111", 3, new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(5902), null, null, 10, true, false },
                    { 2, "3333", 4, new DateTime(2024, 3, 28, 20, 39, 41, 242, DateTimeKind.Local).AddTicks(5964), null, null, 5, true, false }
                });

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
    }
}

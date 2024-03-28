using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 9, 44, 625, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 3, 26, 19, 9, 44, 625, DateTimeKind.Local).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 9, 44, 625, DateTimeKind.Local).AddTicks(4119), new DateTime(2024, 3, 26, 19, 9, 44, 625, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 9, 44, 625, DateTimeKind.Local).AddTicks(4124), new DateTime(2024, 3, 26, 19, 9, 44, 625, DateTimeKind.Local).AddTicks(4126) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9906), new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9912) });
        }
    }
}

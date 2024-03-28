using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookInventorys",
                table: "BookInventorys");

            migrationBuilder.RenameTable(
                name: "BookInventorys",
                newName: "BookInventories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookInventories",
                table: "BookInventories",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 26, 10, 270, DateTimeKind.Local).AddTicks(105), new DateTime(2024, 3, 26, 21, 26, 10, 270, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 26, 10, 270, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 3, 26, 21, 26, 10, 270, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 21, 26, 10, 270, DateTimeKind.Local).AddTicks(175), new DateTime(2024, 3, 26, 21, 26, 10, 270, DateTimeKind.Local).AddTicks(176) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookInventories",
                table: "BookInventories");

            migrationBuilder.RenameTable(
                name: "BookInventories",
                newName: "BookInventorys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookInventorys",
                table: "BookInventorys",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 35, 2, 61, DateTimeKind.Local).AddTicks(1007), new DateTime(2024, 3, 26, 19, 35, 2, 61, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 35, 2, 61, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 3, 26, 19, 35, 2, 61, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 26, 19, 35, 2, 61, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 3, 26, 19, 35, 2, 61, DateTimeKind.Local).AddTicks(1069) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class newfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookInventorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BarCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCheckedOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsOverDue = table.Column<bool>(type: "bit", nullable: true),
                    InventoryCount = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookInventorys", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookInventorys");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Customers");

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
    }
}

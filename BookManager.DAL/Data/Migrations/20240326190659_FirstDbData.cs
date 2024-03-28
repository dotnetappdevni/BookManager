using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstDbData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BarCode", "Condition", "DateCreated", "DateDeleted", "DateModified", "Description", "Genre", "ISBN", "IsActive", "IsDeleted", "Price", "Title", "Type" },
                values: new object[,]
                {
                    { 3, "1111", 0, new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9853), null, new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9900), "After stopping off at Starbase Yorktown, a remote outpost on the fringes of Federation space, the USS Enterprise, halfway into their five-year mission, is destroyed by an unstoppable wave of unknown aliens.", 0, "329-320-2392-1", true, false, 15.99m, "Star Trek - Beyond", 1 },
                    { 4, "3333", 0, new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9906), null, new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9907), "The novelization of the \"First Contact\" film which also includes a behind-the-scenes look at the making of the film. Captain Pickard, Commander Riker, Lieutenant Commander Data and the rest of the crew must face their greatest foe, the half-organic, half-mechanical Borg..", 0, "978-0-671-56743-1", true, false, 10.99m, "Star Trek - First Contact", 1 },
                    { 5, "4444", 0, new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9910), null, new DateTime(2024, 3, 26, 19, 6, 58, 677, DateTimeKind.Local).AddTicks(9912), "Landing on Earth, the Doctor finds a stranded alien in need of protection – and is dragged headlong into the life of his old friend Donna Noble, knowing that if she ever remembers their time together, she will die…", 0, "978-1-84607-571-7", true, false, 16.00m, "Doctor Who: The Star Beast ", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

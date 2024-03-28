using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30f0f81d-87fe-458c-91f1-f7e8bfdaed94", "AQAAAAIAAYagAAAAECZSfP6NjICJeAuWpVT8H/ulWDFyL0y3hZ9WOxN3azVxhwufaWtB0JX1r3hZ2CuLpA==", "b81e1d01-07aa-478f-a202-6c93b3052911" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c809a97-09f2-488c-bebc-6f1d6eea1279", "AQAAAAIAAYagAAAAEIYESejb+AzPuG3ce9NQJK2Mv9d/gnGnRgsAKbjcXprR791RmG5bMGqBZVDttTk8tA==", "3650d984-fb73-48d9-a8d0-edba39873493" });

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7682), new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7690), new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7705), new DateTime(2024, 3, 28, 15, 55, 41, 864, DateTimeKind.Local).AddTicks(7706) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

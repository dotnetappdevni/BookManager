using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caec7515-af1b-435c-86ea-974a07d1c883", "AQAAAAIAAYagAAAAEJhwCDzqpp6Fj5MB5gF5OWM23Gup937a5zrI2iQMLDqII2sMhL/HrGUGIQlP2nHobg==", "9aa50406-4789-472f-9ce1-1cb29f030b45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89204dbb-4053-4040-88f3-e7a84ec8a98f", "AQAAAAIAAYagAAAAEK3VdUDLaVdptGmxQr9s2x+4OSLc0PQO2HoT6zkchuWUR5L0GhbAzb9icYaeM+hh9Q==", "47dea264-8537-4a5d-b8be-bfec8733231f" });

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "BookInventories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1134), new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1141), new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1145), new DateTime(2024, 3, 28, 15, 58, 56, 778, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address1", "Address2", "Address3", "Address4", "Address5", "Country", "County", "DateCreated", "DateDeleted", "DateModified", "Email", "Forename", "IsActive", "IsDeleted", "MiddleName", "Notes", "PostCode", "Surname" },
                values: new object[,]
                {
                    { 6, null, null, null, null, null, null, null, null, null, null, null, "The", null, null, null, null, null, "Doctor" },
                    { 7, null, null, null, null, null, null, null, null, null, null, null, "Martha", null, null, null, null, null, "Jones" },
                    { 8, null, null, null, null, null, null, null, null, null, null, null, "Amy", null, null, null, null, null, "Pond" },
                    { 9, null, null, null, null, null, null, null, null, null, null, null, "River", null, null, null, null, null, "Song" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address1", "Address2", "Address3", "Address4", "Address5", "Country", "County", "DateCreated", "DateDeleted", "DateModified", "Email", "Forename", "IsActive", "IsDeleted", "MiddleName", "Notes", "PostCode", "Surname" },
                values: new object[,]
                {
                    { 1, null, null, null, null, null, null, null, null, null, null, null, "The", null, null, null, null, null, "Doctor" },
                    { 2, null, null, null, null, null, null, null, null, null, null, null, "Martha", null, null, null, null, null, "Jones" },
                    { 3, null, null, null, null, null, null, null, null, null, null, null, "Amy", null, null, null, null, null, "Pond" },
                    { 4, null, null, null, null, null, null, null, null, null, null, null, "River", null, null, null, null, null, "Song" }
                });
        }
    }
}

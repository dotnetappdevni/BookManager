using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address1", "Address2", "Address3", "Address4", "Address5", "Country", "County", "DateCreated", "DateDeleted", "DateModified", "Email", "Forename", "IsActive", "IsDeleted", "MiddleName", "Notes", "PostCode", "Surname" },
                values: new object[,]
                {
                    { 10, null, null, null, null, null, null, null, null, null, null, null, "The", true, false, null, null, null, "Doctor" },
                    { 11, null, null, null, null, null, null, null, null, null, null, null, "Martha", true, false, null, null, null, "Jones" },
                    { 12, null, null, null, null, null, null, null, null, null, null, null, "Amy", true, false, null, null, null, "Pond" },
                    { 13, null, null, null, null, null, null, null, null, null, null, null, "River", true, false, null, null, null, "Song" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13);

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
    }
}

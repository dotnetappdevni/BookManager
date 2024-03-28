using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class somenewfixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BarCode",
                table: "BooksLoand",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BarCode",
                table: "BooksLoand");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d48f9510-b442-4eba-8fcd-1b6e96ca66f0", "AQAAAAIAAYagAAAAEDPi40c64zRwZcHU6P3UlO1RrbUFoFl12zVcKi/gjtRUrKL/A8lqbwRKaHgvkRKhxg==", "166cf532-74e7-43b3-b1e4-ec91ddf5e5ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6af1bc26-fa92-4883-adf7-5ed0fa534bb9", "AQAAAAIAAYagAAAAEIXt+KrKuWxnJ5GiuvkxEziivb2MdxG5nUa3Dnevzr+6z+vvvvuOLbclms/BvcTKdQ==", "179872a8-8348-48f8-a6c9-e48cbb63724f" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6313), new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6370), new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6371) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6374), new DateTime(2024, 3, 28, 11, 6, 54, 628, DateTimeKind.Local).AddTicks(6375) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManager.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewTablesLocationetc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Forename",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    ShelfNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Locations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ref_Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ref_Categorys", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "Administrator", "ADMINISTRATOR" },
                    { "8cc980c3-8643-4166-8dcb-de924036ec6b", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "375af7c9-c524-4fdb-844f-d6dd9cfb09bc", "Admin@EDT.COM", false, false, null, "ADMIN@EDT.COM", "ADMIN", "AQAAAAIAAYagAAAAEHoPWbJmzxkXRqV930qMtKUoKM+RL4Shd6ZbsDx1XfCqipoi7wDyRcYPS2UPSUadHg==", null, false, "b51b883f-c462-4f2f-8ca7-7273fc0b476a", false, "Admin" },
                    { "d18e858a-c38d-4083-99b6-c5697b81d7cd", 0, "1daa0f06-3f97-4a9c-a0a7-ac5158783f89", "Staff@EDT.COM", false, false, null, "STAFF@EDT.COM", "STAFF", "AQAAAAIAAYagAAAAEFzk/YrpNi5s2+Wmw8LtS2/T3vs0XAToC+0S8gfn8uCwBiHmRT2JswrvfhNrHEdyqg==", null, false, "2ea559a8-4b36-40fe-92c1-311b359d59fe", false, "Staff" }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9313), new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9317), new DateTime(2024, 3, 28, 10, 44, 21, 474, DateTimeKind.Local).AddTicks(9318) });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "8cc980c3-8643-4166-8dcb-de924036ec6b", "d18e858a-c38d-4083-99b6-c5697b81d7cd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Ref_Categorys");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8cc980c3-8643-4166-8dcb-de924036ec6b", "d18e858a-c38d-4083-99b6-c5697b81d7cd" });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cc980c3-8643-4166-8dcb-de924036ec6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d18e858a-c38d-4083-99b6-c5697b81d7cd");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Forename",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,3)");

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
    }
}

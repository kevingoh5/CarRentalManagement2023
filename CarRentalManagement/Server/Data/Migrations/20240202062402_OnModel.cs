using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class OnModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "e9cf3317-9829-4b00-8907-af79ae27c64d", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEL87K3QsMQRCJblj5IeBVcI05DQpgE8L6BQ5EqGFSQclJPXTKrRZCAWLYZtf8pzHDw==", null, false, "31c5f230-b34a-4dec-87f8-7d7ec1a3984d", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6167), new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6184), new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6184) });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6534), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6537), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6789), "3 Series", "System" },
                    { 2, "System", new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6791), new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6791), "X5", "System" },
                    { 3, "System", new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6793), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6794), new DateTime(2024, 2, 2, 14, 24, 2, 639, DateTimeKind.Local).AddTicks(6794), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 2, 42, 286, DateTimeKind.Local).AddTicks(2010), new DateTime(2024, 2, 2, 14, 2, 42, 286, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 2, 2, 14, 2, 42, 286, DateTimeKind.Local).AddTicks(2027), new DateTime(2024, 2, 2, 14, 2, 42, 286, DateTimeKind.Local).AddTicks(2027) });
        }
    }
}

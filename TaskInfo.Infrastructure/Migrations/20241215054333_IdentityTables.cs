using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskInfo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("593c5ed4-9a33-4a2b-b546-2a11579add90"), new Guid("f1ee2a8f-3e1d-4bb7-8821-95d78a954a83") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("66f1605f-ee3e-41c1-9f96-83b5698ca6d5"), new Guid("fdbe7719-018f-40c5-a72e-b4b62029cfc3") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("593c5ed4-9a33-4a2b-b546-2a11579add90"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("66f1605f-ee3e-41c1-9f96-83b5698ca6d5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f1ee2a8f-3e1d-4bb7-8821-95d78a954a83"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fdbe7719-018f-40c5-a72e-b4b62029cfc3"));

            migrationBuilder.UpdateData(
                table: "AllTasksTable",
                keyColumn: "Title",
                keyValue: "Test",
                columns: new[] { "DueDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 20, 11, 13, 32, 304, DateTimeKind.Local).AddTicks(8975), new Guid("512c57a3-36f1-4915-9454-819050a6f592") });

            migrationBuilder.UpdateData(
                table: "AllTasksTable",
                keyColumn: "Title",
                keyValue: "Test2",
                columns: new[] { "DueDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 25, 11, 13, 32, 306, DateTimeKind.Local).AddTicks(4426), new Guid("512c57a3-36f1-4915-9454-819050a6f592") });

            migrationBuilder.UpdateData(
                table: "AllUsersTable",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "UserId",
                value: new Guid("eafdec1b-49bb-4bc9-9370-ef8d4ceb2a0a"));

            migrationBuilder.UpdateData(
                table: "AllUsersTable",
                keyColumn: "UserName",
                keyValue: "user",
                column: "UserId",
                value: new Guid("512c57a3-36f1-4915-9454-819050a6f592"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("18699eb5-453a-48bf-b418-de42c360b853"), null, "Admin", "ADMIN" },
                    { new Guid("57c93ca2-9390-4b98-afd2-e3f5fa3e7cb6"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("512c57a3-36f1-4915-9454-819050a6f592"), 0, "88a1560e-486c-4639-9563-8a20d089faa5", null, false, false, null, null, "USER", "AQAAAAIAAYagAAAAEDW6ibMWB+fYqwodHdpazQFff2B4LSFqM/UWwD11FtUhregOqFafM0GfXAZ91ok/9Q==", null, false, null, null, "23923e19-7847-4b16-91ae-8ab1330ff005", false, "user" },
                    { new Guid("eafdec1b-49bb-4bc9-9370-ef8d4ceb2a0a"), 0, "161bf30c-eb52-4b4a-a47d-7740030b097e", null, false, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEJHaVTmptBWH/wprfJ63LT/Em+19QZAbumIyBioPSLQx+MQ7eGohpUMnX7LKwuXdEA==", null, false, null, null, "37f5541b-0abe-4cea-b2e1-8fe7a9563c70", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57c93ca2-9390-4b98-afd2-e3f5fa3e7cb6"), new Guid("512c57a3-36f1-4915-9454-819050a6f592") },
                    { new Guid("18699eb5-453a-48bf-b418-de42c360b853"), new Guid("eafdec1b-49bb-4bc9-9370-ef8d4ceb2a0a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("57c93ca2-9390-4b98-afd2-e3f5fa3e7cb6"), new Guid("512c57a3-36f1-4915-9454-819050a6f592") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("18699eb5-453a-48bf-b418-de42c360b853"), new Guid("eafdec1b-49bb-4bc9-9370-ef8d4ceb2a0a") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("18699eb5-453a-48bf-b418-de42c360b853"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("57c93ca2-9390-4b98-afd2-e3f5fa3e7cb6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("512c57a3-36f1-4915-9454-819050a6f592"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("eafdec1b-49bb-4bc9-9370-ef8d4ceb2a0a"));

            migrationBuilder.UpdateData(
                table: "AllTasksTable",
                keyColumn: "Title",
                keyValue: "Test",
                columns: new[] { "DueDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 43, 35, 92, DateTimeKind.Local).AddTicks(1757), new Guid("f1ee2a8f-3e1d-4bb7-8821-95d78a954a83") });

            migrationBuilder.UpdateData(
                table: "AllTasksTable",
                keyColumn: "Title",
                keyValue: "Test2",
                columns: new[] { "DueDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 24, 17, 43, 35, 93, DateTimeKind.Local).AddTicks(3977), new Guid("f1ee2a8f-3e1d-4bb7-8821-95d78a954a83") });

            migrationBuilder.UpdateData(
                table: "AllUsersTable",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "UserId",
                value: new Guid("fdbe7719-018f-40c5-a72e-b4b62029cfc3"));

            migrationBuilder.UpdateData(
                table: "AllUsersTable",
                keyColumn: "UserName",
                keyValue: "user",
                column: "UserId",
                value: new Guid("f1ee2a8f-3e1d-4bb7-8821-95d78a954a83"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("593c5ed4-9a33-4a2b-b546-2a11579add90"), null, "User", "USER" },
                    { new Guid("66f1605f-ee3e-41c1-9f96-83b5698ca6d5"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("f1ee2a8f-3e1d-4bb7-8821-95d78a954a83"), 0, "567c711f-1941-41a5-b86c-fae1484902a6", null, false, false, null, null, "USER", "AQAAAAIAAYagAAAAEBRTVFus+Tc7hCgwKm6grq7oiznGrjQOLwgVIfsMDAcOZOvE0m+iXHka/MpMWoq4AA==", null, false, null, null, "ccc36b56-bbf9-41f8-ac10-bd5401cd8e83", false, "user" },
                    { new Guid("fdbe7719-018f-40c5-a72e-b4b62029cfc3"), 0, "cbc7debc-5fa0-48fc-8dfb-09a82ab3659a", null, false, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEHDkCElvXhCWYu4xyQNawJjT5tXP6LML5PcJnPMIzzBEt0UA2FDpOLXh2+BxuFDWWQ==", null, false, null, null, "a92308b6-74c2-4a9d-afb8-76e3f29d806a", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("593c5ed4-9a33-4a2b-b546-2a11579add90"), new Guid("f1ee2a8f-3e1d-4bb7-8821-95d78a954a83") },
                    { new Guid("66f1605f-ee3e-41c1-9f96-83b5698ca6d5"), new Guid("fdbe7719-018f-40c5-a72e-b4b62029cfc3") }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskInfo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RefreshTokenExpiration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1c753710-5270-40e9-9fa2-95f201a24fd5"), new Guid("6d831998-ca41-41d9-b543-d76b8329b49f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3552932a-a028-49bf-a3ee-c5c59f5bbe87"), new Guid("8378a5b5-5ac6-49f6-a8b8-323f2ed7019b") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1c753710-5270-40e9-9fa2-95f201a24fd5"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3552932a-a028-49bf-a3ee-c5c59f5bbe87"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6d831998-ca41-41d9-b543-d76b8329b49f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8378a5b5-5ac6-49f6-a8b8-323f2ed7019b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 12, 19, 17, 35, 31, 18, DateTimeKind.Local).AddTicks(689), new Guid("6d831998-ca41-41d9-b543-d76b8329b49f") });

            migrationBuilder.UpdateData(
                table: "AllTasksTable",
                keyColumn: "Title",
                keyValue: "Test2",
                columns: new[] { "DueDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 24, 17, 35, 31, 19, DateTimeKind.Local).AddTicks(827), new Guid("6d831998-ca41-41d9-b543-d76b8329b49f") });

            migrationBuilder.UpdateData(
                table: "AllUsersTable",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "UserId",
                value: new Guid("8378a5b5-5ac6-49f6-a8b8-323f2ed7019b"));

            migrationBuilder.UpdateData(
                table: "AllUsersTable",
                keyColumn: "UserName",
                keyValue: "user",
                column: "UserId",
                value: new Guid("6d831998-ca41-41d9-b543-d76b8329b49f"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1c753710-5270-40e9-9fa2-95f201a24fd5"), null, "User", "USER" },
                    { new Guid("3552932a-a028-49bf-a3ee-c5c59f5bbe87"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6d831998-ca41-41d9-b543-d76b8329b49f"), 0, "ca0953f1-672d-46c7-82b7-4dffad640058", null, false, false, null, null, "USER", "AQAAAAIAAYagAAAAEHcMUdN0NH6Wzk2Dwd6LwT9NbaDp/wTaT4qYVtkOlg7BR06BEyGmtGPVuWlEmBv1qQ==", null, false, null, null, "c98a251e-5fbc-47dc-9043-559bc2c0e3b8", false, "user" },
                    { new Guid("8378a5b5-5ac6-49f6-a8b8-323f2ed7019b"), 0, "1bd4e771-1cb6-40fb-91e0-1aebd48f5351", null, false, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAEC7cfdfPkwOnuz/xx5pyut2TTVnKuHJqJ8GPfBlkoo5AbuuRroJR4yLw+2tqN6DqtQ==", null, false, null, null, "725d7b59-c19f-488c-8aa6-8626f38af4a4", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c753710-5270-40e9-9fa2-95f201a24fd5"), new Guid("6d831998-ca41-41d9-b543-d76b8329b49f") },
                    { new Guid("3552932a-a028-49bf-a3ee-c5c59f5bbe87"), new Guid("8378a5b5-5ac6-49f6-a8b8-323f2ed7019b") }
                });
        }
    }
}

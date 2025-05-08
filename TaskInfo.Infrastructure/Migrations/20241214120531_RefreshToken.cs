using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskInfo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e2e78815-e42a-4c80-a033-aaeb1e1aac90"), new Guid("023bbd5c-98e7-4d10-bd13-daa4cae444cc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("e39361e2-efd1-441a-a674-fbabc4b65775"), new Guid("36e65da8-f2f0-40dc-8448-b0c24a0387be") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e2e78815-e42a-4c80-a033-aaeb1e1aac90"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e39361e2-efd1-441a-a674-fbabc4b65775"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("023bbd5c-98e7-4d10-bd13-daa4cae444cc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("36e65da8-f2f0-40dc-8448-b0c24a0387be"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2024, 12, 16, 10, 56, 40, 818, DateTimeKind.Local).AddTicks(718), new Guid("36e65da8-f2f0-40dc-8448-b0c24a0387be") });

            migrationBuilder.UpdateData(
                table: "AllTasksTable",
                keyColumn: "Title",
                keyValue: "Test2",
                columns: new[] { "DueDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 21, 10, 56, 40, 819, DateTimeKind.Local).AddTicks(6415), new Guid("36e65da8-f2f0-40dc-8448-b0c24a0387be") });

            migrationBuilder.UpdateData(
                table: "AllUsersTable",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "UserId",
                value: new Guid("023bbd5c-98e7-4d10-bd13-daa4cae444cc"));

            migrationBuilder.UpdateData(
                table: "AllUsersTable",
                keyColumn: "UserName",
                keyValue: "user",
                column: "UserId",
                value: new Guid("36e65da8-f2f0-40dc-8448-b0c24a0387be"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("e2e78815-e42a-4c80-a033-aaeb1e1aac90"), null, "Admin", "ADMIN" },
                    { new Guid("e39361e2-efd1-441a-a674-fbabc4b65775"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("023bbd5c-98e7-4d10-bd13-daa4cae444cc"), 0, "bd54606e-5fae-4c93-8848-5f68acadcf26", null, false, false, null, null, "ADMIN", "AQAAAAIAAYagAAAAECoe3uWCyJfhByRRTYnVcxuN7yddS7Lp/pZ3YhqwokiwM/nUx54vgPPub8Jq79P9JA==", null, false, null, null, "fb011999-a119-4c75-867c-267c09f626b6", false, "admin" },
                    { new Guid("36e65da8-f2f0-40dc-8448-b0c24a0387be"), 0, "a75321a6-d22c-4212-885d-7e29d2c99cb7", null, false, false, null, null, "USER", "AQAAAAIAAYagAAAAEDfvbFSNqh4LtPCN0gZZEZMORDAvfB/SHtlkXlNZCeYpO6BOKvNctUYP7CIhE9+baQ==", null, false, null, null, "c5efe90d-f13c-4403-975b-57e72124461a", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e2e78815-e42a-4c80-a033-aaeb1e1aac90"), new Guid("023bbd5c-98e7-4d10-bd13-daa4cae444cc") },
                    { new Guid("e39361e2-efd1-441a-a674-fbabc4b65775"), new Guid("36e65da8-f2f0-40dc-8448-b0c24a0387be") }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Management.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData12255121 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 20, 1, 599, DateTimeKind.Utc).AddTicks(3490), "$2a$11$aYwD4DgvmJtKUeoK4W3bX.mFV4LLpzoPXRN6b2Uy5WLH09giLjqca" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 20, 1, 729, DateTimeKind.Utc).AddTicks(4763), "$2a$11$M3ErFQwilq0Iucvqk2inaOnOJ29E2/toAGYFcpKeamWmG2zFYHwlC" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 19, 11, 727, DateTimeKind.Utc).AddTicks(8857), "$2a$11$2crCh1qUoG736tKzGTk5mekdAELancevFHWxQG2.WJsHfrtytc1hS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 19, 11, 849, DateTimeKind.Utc).AddTicks(9141), "$2a$11$iX74t4DokRsNfek9Hj/0m.AIfZxSQ7tOy1DUJ3V5hfME/IdYbD3e2" });
        }
    }
}

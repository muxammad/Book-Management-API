using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Management.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1200 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 18, 33, 561, DateTimeKind.Utc).AddTicks(446), "$2a$11$FSRNJllZITxQ.FeKBlloj./KzzbUXGC1SC42xvFM7.4HrOi2a6L.C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 18, 33, 677, DateTimeKind.Utc).AddTicks(149), "$2a$11$nbUjl41pVYnNzmT7s1HnWe4/SGjSvmEC1tECTpkXSn0yPlvt9/vBq" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 13, 33, 124, DateTimeKind.Utc).AddTicks(5620), "$2a$11$GTmKiY0Q.lkIjSJj9AplY.8UzuxjyElSgaBuEKNt01qEZ/6JR1Gnu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 13, 33, 240, DateTimeKind.Utc).AddTicks(7224), "$2a$11$NRxhqiHVSKbmLqsRB7Yj.e8IcrJlPmq843HaceazUaNa1hGoZjT6q" });
        }
    }
}

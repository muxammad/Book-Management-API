using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Management.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 14, 57, 12, 211, DateTimeKind.Utc).AddTicks(1558), "$2a$11$Uo3UZbBRW2eQUhyMm5eXjuWT3O395YXmlBAw9qFdbGR7x24t1kBeu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 14, 57, 12, 333, DateTimeKind.Utc).AddTicks(4359), "$2a$11$js0h2xvKp2D08GAAOYAe9uAncvlRV.TQUYm1xPHVneG9B.s.XMNcy" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5884), "$2a$11$Ct2lalVK/B29BD3UIRoMseLLAS9eZ4nWy1xQM2DefRQoWN0pzPUU2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2025, 2, 23, 14, 54, 11, 224, DateTimeKind.Utc).AddTicks(997), "$2a$11$ID8dsab5.uhxqaTTQjFpWeHtiZyAM2pbGasfUCRZFKKWLrvI64T0y" });
        }
    }
}

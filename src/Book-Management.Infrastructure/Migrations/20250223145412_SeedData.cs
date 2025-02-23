using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Management.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Email", "IsDeleted", "Name", "Password", "PhoneNumber", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"), new DateTime(2025, 2, 23, 14, 54, 11, 39, DateTimeKind.Utc).AddTicks(5884), null, "Muhammadali@gmail.com", false, "Muhammadali", "$2a$11$Ct2lalVK/B29BD3UIRoMseLLAS9eZ4nWy1xQM2DefRQoWN0pzPUU2", "+998900206000", 0, null },
                    { new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"), new DateTime(2025, 2, 23, 14, 54, 11, 224, DateTimeKind.Utc).AddTicks(997), null, "alisher@gmail.com", false, "Alisher", "$2a$11$ID8dsab5.uhxqaTTQjFpWeHtiZyAM2pbGasfUCRZFKKWLrvI64T0y", "+998900205000", 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"));

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9944));
        }
    }
}

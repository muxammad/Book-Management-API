using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_Management.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intial002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreatedAt", "DeletedAt", "IsDeleted", "PublicationYear", "Title", "UpdatedAt", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"), "Jane Austen", new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9952), null, false, new DateTime(1813, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pride and Prejudice", null, 180 },
                    { new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"), "J.R.R. Tolkien", new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9957), null, false, new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings", null, 300 },
                    { new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"), "Harper Lee", new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9946), null, false, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To Kill a Mockingbird", null, 150 },
                    { new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"), "J.D. Salinger", new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9955), null, false, new DateTime(1951, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Catcher in the Rye", null, 220 },
                    { new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"), "Aldous Huxley", new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9958), null, false, new DateTime(1932, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brave New World", null, 170 },
                    { new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"), "F. Scott Fitzgerald", new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9932), null, false, new DateTime(1925, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Gatsby", null, 100 },
                    { new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"), "Herman Melville", new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9954), null, false, new DateTime(1851, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moby-Dick", null, 90 },
                    { new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"), "George Orwell", new DateTime(2025, 2, 23, 10, 44, 27, 235, DateTimeKind.Utc).AddTicks(9944), null, false, new DateTime(1949, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984", null, 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"));
        }
    }
}

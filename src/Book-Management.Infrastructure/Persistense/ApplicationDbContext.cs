using Book_Management.Domain.Entities;
using Book_Management.Domain.Enums;
using Book_Managment.Application.Abstractions;
using Book_Managment.Application.Helper;
using Microsoft.EntityFrameworkCore;

namespace Book_Management.Infrastructure.Persistense
{
    public class ApplicationDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions), IApplicationDbContext
    {
        public DbSet<Book> Books { get ; set; }
        public DbSet<User> Users { get ; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    PublicationYear = new DateTime(1925, 1, 1),
                    ViewCount = 100
                },
                new Book
                {
                    Id = new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                    Title = "1984",
                    Author = "George Orwell",
                    PublicationYear = new DateTime(1949, 1, 1),
                    ViewCount = 200
                },
                new Book
                {
                    Id = new Guid("9b2f74e2-cf32-42bb-8c39-5f8f658a3b99"),
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    PublicationYear = new DateTime(1960, 1, 1),
                    ViewCount = 150
                },
                new Book
                {
                    Id = new Guid("3c1a2e3d-77d5-4e9c-a2b5-0b5c9d7e2f3a"),
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    PublicationYear = new DateTime(1813, 1, 1),
                    ViewCount = 180
                },
                new Book
                {
                    Id = new Guid("e45a8b9a-5f13-4e59-8a6b-4e8d2f6a3b2d"),
                    Title = "Moby-Dick",
                    Author = "Herman Melville",
                    PublicationYear = new DateTime(1851, 1, 1),
                    ViewCount = 90
                },
                new Book
                {
                    Id = new Guid("a1f4c3e6-8b4f-4c6e-b5a4-2e8b6c3f1d2a"),
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    PublicationYear = new DateTime(1951, 1, 1),
                    ViewCount = 220
                },
                new Book
                {
                    Id = new Guid("6d9f2b4e-3a4c-4d5e-9a8b-2c6f3b1e8d4a"),
                    Title = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    PublicationYear = new DateTime(1954, 1, 1),
                    ViewCount = 300
                },
                new Book
                {
                    Id = new Guid("b4e6f9a2-3c1d-4e5b-9a8f-6c3b2d1a4e8b"),
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    PublicationYear = new DateTime(1932, 1, 1),
                    ViewCount = 170
                }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = new Guid("d290f1ee-6c54-4b01-90e6-d701748f0851"),
                    Name = "Muhammadali",
                    Email = "Muhammadali@gmail.com",
                    Password = PasswordHelper.Hash("Admin123"),
                    Role = UserRole.Admin

                },

                new User
                {
                    Id = new Guid("f29b7a7b-4e1d-4f3d-b6b1-85d3e2486e2b"),
                    Name = "Alisher",
                    Email = "alisher@gmail.com",
                    Password = PasswordHelper.Hash("User123"),
                    Role = UserRole.User
                }
            );
        }
    }
}

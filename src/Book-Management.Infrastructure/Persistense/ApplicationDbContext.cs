using Book_Management.Domain.Entities;
using Book_Managment.Application.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Book_Management.Infrastructure.Persistense
{
    public class ApplicationDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions), IApplicationDbContext
    {
        public DbSet<Book> Books { get ; set; }
        public DbSet<User> Users { get ; set; }

    }
}

using Book_Management.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Book_Managment.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}

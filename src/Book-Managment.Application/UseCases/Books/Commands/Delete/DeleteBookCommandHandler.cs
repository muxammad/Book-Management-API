using Book_Managment.Application.Abstractions;
using Book_Managment.Application.Exceptions;

namespace Book_Managment.Application.UseCases.Books.Commands.Delete
{
    public class DeleteBookCommandHandler(IApplicationDbContext dbContext) : ICommandHandler<DeleteBookCommand, bool>
    {
        private readonly IApplicationDbContext dbContext = dbContext;

        public async Task<bool> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var booksToDelete = dbContext.Books.Where(x => request.BookIds.Contains(x.Id) && !x.IsDeleted).ToList();

            if (!booksToDelete.Any())
            {
                throw new CustomException("No books found to delete");
            }

            foreach (var book in booksToDelete)
            {
                book.IsDeleted = true;
                book.DeletedAt = DateTime.UtcNow;
            }

            dbContext.Books.UpdateRange(booksToDelete);
            return await dbContext.SaveChangesAsync(cancellationToken) > 0;

        }
    }
}

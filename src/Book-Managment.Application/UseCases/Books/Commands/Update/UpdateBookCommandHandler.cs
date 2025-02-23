
using Book_Managment.Application.Abstractions;
using Book_Managment.Application.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Book_Managment.Application.UseCases.Books.Commands.Update
{
    public class UpdateBookCommandHandler(IApplicationDbContext dbContext) : ICommandHandler<UpdateBookCommand, bool>
    {
        private readonly IApplicationDbContext dbContext = dbContext;
        public async Task<bool> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = dbContext.Books
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == request.Id && !x.IsDeleted) ?? throw new BookNotFountException();

            book.Title = request.Title;
            book.Author = request.Author;
            book.PublicationYear = request.PublicationYear;
            book.ViewCount = request.ViewCount;
            book.UpdatedAt = DateTime.UtcNow;
            book.CreatedAt = book.CreatedAt;

            dbContext.Books.Update(book);
            return await dbContext.SaveChangesAsync(cancellationToken) > 0;

        }
    }
}

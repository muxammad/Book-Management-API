using Book_Management.Domain.Entities;
using Book_Managment.Application.Abstractions;
using Book_Managment.Application.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Book_Managment.Application.UseCases.Books.Commands.Add
{
    public class AddBookCommandHandler(IApplicationDbContext dbContext) : ICommandHandler<AddBookCommand, bool>
    {
        private readonly IApplicationDbContext dbContext = dbContext;

        public async Task<bool> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var requestBookTitles = request.Books.Select(x => x.Title).ToList();

            var existingBooks = dbContext.Books
                .AsNoTracking()
                .Where(b => requestBookTitles.Contains(b.Title) == !b.IsDeleted)
                .Select(b => b.Title)
                .ToList();

            var dublicates = request.Books
                .Where(x => existingBooks.Contains(x.Title))
                .Select(b => b.Title)
                .ToList();

            if (dublicates.Count != 0)
            {
                throw new BookAlreadyExistException($"Books with titles {string.Join(", ", dublicates)} already exist.");
            }

            var newBooks = request.Books.Where(b => !existingBooks.Contains(b.Title)).Select(b => new Book
            {
                Title = b.Title,
                Author = b.Author,
                PublicationYear = b.PublicationYear
            }).ToList();

            if (!newBooks.Any())
                return false;

            await dbContext.Books.AddRangeAsync(newBooks, cancellationToken);
            return await dbContext.SaveChangesAsync(cancellationToken) > 0;
        }
    }
}

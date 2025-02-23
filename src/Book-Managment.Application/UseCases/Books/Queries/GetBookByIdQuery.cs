using Book_Managment.Application.Abstractions;
using Book_Managment.Application.DTOs.Books;
using Book_Managment.Application.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Book_Managment.Application.UseCases.Books.Queries
{
    public class GetBookByIdQuery : IQuery<BookDetailsViewModel>
    {
        public Guid Id { get; set; }
    }

    public class GetBookByIdQueryHandler(IApplicationDbContext dbContext) : IQueryHandler<GetBookByIdQuery, BookDetailsViewModel>
    {
        private readonly IApplicationDbContext dbContext = dbContext;

        public async Task<BookDetailsViewModel> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await dbContext.Books
                       .FirstOrDefaultAsync(b => b.Id == request.Id && !b.IsDeleted, cancellationToken: cancellationToken)
                       ?? throw new BookNotFountException();

            book.ViewCount++;
            await dbContext.SaveChangesAsync(cancellationToken);

            var bookDetails = new BookDetailsViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                ViewCount = book.ViewCount,
                PublicationYear = book.PublicationYear.Year,
                PopularityScore = CalculatePopularityScore(book.ViewCount, book.PublicationYear)
            };

            return bookDetails;

        }

        private double CalculatePopularityScore(int viewCount, DateTime publicationYear)
        {
            var yearsSincePublished = DateTime.UtcNow.Year - publicationYear.Year;
            return (viewCount * 0.5) + (yearsSincePublished * 2);
        }
    }
}

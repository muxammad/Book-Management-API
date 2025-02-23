using Book_Managment.Application.Abstractions;
using Book_Managment.Application.DTOs.Books;
using Book_Managment.Application.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Book_Managment.Application.UseCases.Books.Queries
{
    public class GetAllBookDetailsQueryHandler(IApplicationDbContext dbContext) : IQueryHandler<GetAllBookDetailsQuery, List<BookDetailsViewModel>>
    {
        private readonly IApplicationDbContext dbContext = dbContext;

        public async Task<List<BookDetailsViewModel>> Handle(GetAllBookDetailsQuery request, CancellationToken cancellationToken)
        {
            var booksQuery = dbContext.Books.Where(x => !x.IsDeleted);

            if (booksQuery.Any())
            {
                foreach (var book in booksQuery)
                {
                    book.ViewCount++;
                }

                await dbContext.SaveChangesAsync(cancellationToken);

                return await booksQuery
                    .ToPagedList(request.Params)
                    .Select(b => new BookDetailsViewModel
                    {
                        Id = b.Id,
                        Title = b.Title,
                        Author = b.Author,
                        PublicationYear = b.PublicationYear,
                        PopularityScore = CalculatePopularityScore(b.ViewCount, b.PublicationYear)
                    }).ToListAsync(cancellationToken: cancellationToken);
            }

            return [];

        }

        private double CalculatePopularityScore(int viewCount, DateTime publicationYear)
        {
            var yearsSincePublished = DateTime.UtcNow.Year - publicationYear.Year;
            return (viewCount * 0.5) + (yearsSincePublished * 2);
        }
    }
}

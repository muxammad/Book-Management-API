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

                dbContext.Books.UpdateRange(booksQuery);
                await dbContext.SaveChangesAsync(cancellationToken);

                return await booksQuery
                    .ToPagedList(request.Params)
                     .Select(b => new BookDetailsViewModel
                     {
                         Id = b.Id,
                         Title = b.Title,
                         Author = b.Author,
                         PublicationYear = b.PublicationYear.Year,
                         ViewCount = b.ViewCount,
                         PopularityScore = b.ViewCount * 0.5 + (DateTime.UtcNow.Year - b.PublicationYear.Year) * 2
                     })
                     .OrderByDescending(b => b.PopularityScore) 
                     .ToListAsync(cancellationToken: cancellationToken);
            }
                return [];

        }

    }
}

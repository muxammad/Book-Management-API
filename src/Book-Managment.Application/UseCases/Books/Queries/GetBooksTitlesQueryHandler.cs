﻿using Book_Managment.Application.Abstractions;
using Book_Managment.Application.DTOs.Books;
using Book_Managment.Application.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Book_Managment.Application.UseCases.Books.Queries
{
    public class GetBooksTitlesQueryHandler(IApplicationDbContext dbContext) : IQueryHandler<GetBooksTitlesQuery, List<BookTitleViewModel>>
    {
        private readonly IApplicationDbContext dbContext = dbContext;

        public async Task<List<BookTitleViewModel>> Handle(GetBooksTitlesQuery request, CancellationToken cancellationToken)
        {
            var books = dbContext.Books
                .AsNoTracking()
                .Where(b => !b.IsDeleted).OrderByDescending(b => b.ViewCount * 0.5 + (DateTime.UtcNow.Year - b.PublicationYear.Year) * 2);
             
            if (!books.Any())
                return [];

            return await books.ToPagedList(request.Params).Select(b => new BookTitleViewModel
            {
                Title = b.Title
            }).ToListAsync(cancellationToken);

        }
    }
}

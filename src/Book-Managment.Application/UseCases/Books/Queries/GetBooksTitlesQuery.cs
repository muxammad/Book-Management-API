using Book_Management.Domain.Configurations;
using Book_Managment.Application.Abstractions;
using Book_Managment.Application.DTOs.Books;

namespace Book_Managment.Application.UseCases.Books.Queries
{
    public class GetBooksTitlesQuery : IQuery<List<BookTitleViewModel>>
    {
        public PaginationParams Params { get; set; }
    }
}

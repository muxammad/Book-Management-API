using Book_Management.Domain.Configurations;
using Book_Management.Domain.Entities;
using Book_Managment.Application.Abstractions;
using Book_Managment.Application.DTOs.Books;

namespace Book_Managment.Application.UseCases.Books.Queries
{
    public class GetAllBookDetailsQuery : IQuery<List<BookDetailsViewModel>>
    {
       public PaginationParams Params { get; set; }
    }
}

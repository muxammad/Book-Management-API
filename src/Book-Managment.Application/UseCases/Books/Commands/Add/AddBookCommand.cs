using Book_Managment.Application.Abstractions;
using Book_Managment.Application.DTOs.Books;

namespace Book_Managment.Application.UseCases.Books.Commands.Add
{
    public record AddBookCommand(List<BookCreationDto> Books) : ICommand<bool>
    {

    }
}

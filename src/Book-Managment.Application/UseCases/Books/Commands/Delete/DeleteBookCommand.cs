using Book_Managment.Application.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Windows.Input;

namespace Book_Managment.Application.UseCases.Books.Commands.Delete
{
    public class DeleteBookCommand : ICommand<bool>
    {
        public required List<Guid> BookIds { get; set; }
    }
}

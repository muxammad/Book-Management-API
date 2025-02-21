using Book_Managment.Application.Abstractions;
using System.Windows.Input;

namespace Book_Managment.Application.UseCases.Books.Commands
{
    public class DeleteBookCommand : ICommand<bool>
    {
        public Guid Id { get; set; }
    }
}

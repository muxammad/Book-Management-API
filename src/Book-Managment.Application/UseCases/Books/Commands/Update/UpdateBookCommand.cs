
using Book_Managment.Application.Abstractions;

namespace Book_Managment.Application.UseCases.Books.Commands.Update
{
    public class UpdateBookCommand : ICommand<bool>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationYear { get; set; }
        public int ViewCount { get; set; }
    }
}

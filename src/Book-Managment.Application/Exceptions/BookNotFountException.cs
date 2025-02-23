namespace Book_Managment.Application.Exceptions
{
    public class BookNotFountException : EntityNotFoundException
    {
        public BookNotFountException()
            : base("Book")
        {
        }
    }
}

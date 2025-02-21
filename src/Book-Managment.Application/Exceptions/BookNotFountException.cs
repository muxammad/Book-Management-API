namespace Book_Managment.Application.Exceptions
{
    public class BookNotFountException : EntityNotFoundException
    {
        public BookNotFountException(string entityName)
            : base("Book")
        {
        }
    }
}

namespace Book_Managment.Application.Exceptions
{
    public class BookAlreadyExistException : EntityAlreadyExistException
    {

        public BookAlreadyExistException(string message) : base(message)
        {
        }
    }
}

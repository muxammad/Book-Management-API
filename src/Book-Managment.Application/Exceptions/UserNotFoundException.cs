namespace Book_Managment.Application.Exceptions
{
    public class UserNotFoundException : EntityNotFoundException
    {
        public UserNotFoundException(string entityName)
            : base("User")
        {
        }
    }
}

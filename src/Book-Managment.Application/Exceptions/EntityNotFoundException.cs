namespace Book_Managment.Application.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public int StatusCode;
        public EntityNotFoundException(string entityName)
            : base($"{entityName}  Not Found")

        {
            StatusCode = 404;
        }
       
    }
}

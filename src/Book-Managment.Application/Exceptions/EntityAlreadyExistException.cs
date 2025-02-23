namespace Book_Managment.Application.Exceptions
{
    public class EntityAlreadyExistException : Exception
    {
        public int StatusCode;
        public EntityAlreadyExistException(string exceptionName) :
            base($"{exceptionName} Already Exist")
        {
            this.StatusCode = 409;
        }
    }
}

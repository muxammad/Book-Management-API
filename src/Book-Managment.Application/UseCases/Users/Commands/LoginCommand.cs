using Book_Managment.Application.Abstractions;

namespace Book_Managment.Application.UseCases.Users.Commands
{
    public class LoginCommand : ICommand<string>
    {
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}

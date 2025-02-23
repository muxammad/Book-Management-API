using Book_Managment.Application.Abstractions;
using Book_Managment.Application.Helper;
using Microsoft.EntityFrameworkCore;

namespace Book_Managment.Application.UseCases.Users.Commands
{
    public class LoginCommandHandler(ITokenService tokenService, IApplicationDbContext dbContext) : ICommandHandler<LoginCommand, string>
    {
        private readonly ITokenService tokenService = tokenService;
        private readonly IApplicationDbContext dbContext = dbContext;

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await dbContext.Users
            .FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber, cancellationToken);

            if (user == null || PasswordHelper.Verify(request.Password, user.Password))
            {
                throw new UnauthorizedAccessException("Invalid credentials.");
            }

            return tokenService.GetAccessTokenUser(user);
        }
    }
}

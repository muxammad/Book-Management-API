namespace Book_Managment.Application.Helper
{
    public static class PasswordHelper
    {
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool Verify(string request, string exsiting)
        {
            return BCrypt.Net.BCrypt.Verify(request, exsiting);
        }
    }
}

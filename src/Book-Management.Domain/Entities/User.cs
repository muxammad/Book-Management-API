using Book_Management.Domain.Commons;
using Book_Management.Domain.Enums;

namespace Book_Management.Domain.Entities
{
    public class User : Auditable
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}

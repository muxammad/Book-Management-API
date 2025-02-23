using Book_Management.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Managment.Application.Abstractions
{
    public interface ITokenService
    {
        string GetAccessTokenUser(User user);
    }
}

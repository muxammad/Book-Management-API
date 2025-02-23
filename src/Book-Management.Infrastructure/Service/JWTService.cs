using Book_Management.Domain.Entities;
using Book_Managment.Application.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management.Infrastructure.Service
{
    public class JWTService(IConfiguration configuration) : ITokenService
    {
        private readonly IConfiguration configuration = configuration;

        public string GetAccessTokenUser(User user)
        {
            var tokenHendler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
            var tokenDisctiptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                new Claim("Id", user.Id.ToString()),
                new Claim("Email", user.Email),
                new Claim("Role", user.Role.ToString()),
                new Claim(ClaimTypes.Name, user.Name)

                }),
                Audience = configuration["JWT:Audience"],
                Issuer = configuration["JWT:Issuer"],
                IssuedAt = DateTime.UtcNow,
                Expires = DateTime.UtcNow.AddDays(int.Parse(configuration["JWT:Expire"])),
                SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHendler.CreateToken(tokenDisctiptor);
            return tokenHendler.WriteToken(token);
        }

      
    }
}

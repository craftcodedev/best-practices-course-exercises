using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BlockbusterApp.src.Shared.Infrastructure.Security.Authentication.JWT
{
    public class JWTEncoder : IJWTEncoder
    {
        private IConfiguration _configuration;

        public JWTEncoder(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Encode(Dictionary<string, string> payload)
        {
            var secret = _configuration.GetValue<string>("AppSettings:Secret");

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("user_id", payload["user_id"]),
                    new Claim("email", payload["email"]),
                    new Claim("first_name", payload["first_name"]),
                    new Claim("last_name", payload["last_name"]),
                    new Claim("role", payload["role"])
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using elearning.IAM.Token.Domain;

namespace elearning.Shared.Infrastructure.Security.Authentication.JWT
{
    public class JWTEncoder : IJWTEncoder
    {
        private IConfiguration _configuration;

        public JWTEncoder(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Encode(Payload payload)
        {
            var secret = _configuration.GetValue<string>("AppSettings:Secret");

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("user_id", payload.UserId),
                    new Claim("email", payload.Email),
                    new Claim("first_name", payload.FirstName),
                    new Claim("last_name", payload.LastName),
                    new Claim("role", payload.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
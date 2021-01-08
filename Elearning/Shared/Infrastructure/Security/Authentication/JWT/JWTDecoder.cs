using System.Linq;
using System.Security.Claims;
using elearning.Shared.Domain;
using elearning.Shared.Infrastructure.Security.Authentication.JWT.Exception;
using Microsoft.AspNetCore.Http;

namespace elearning.Shared.Infrastructure.Security.Authentication.JWT
{
    public class JWTDecoder : IJWTDecoder
    {
        private IHttpContextAccessor context;

        public JWTDecoder(IHttpContextAccessor context)
        {
            this.context = context;
        }

        public AuthUser Decode()
        {
            HttpContext context = this.context.HttpContext;

            if (context.User.Claims.Count() == 0)
            {
                throw InvalidJWTDecodification.FromTokenUser();
            }

            string id = context.User.FindFirst("user_id").Value;
            string email = context.User.FindFirst(ClaimTypes.Email).Value;
            string firstName = context.User.FindFirst("first_name").Value;
            string lastName = context.User.FindFirst("last_name").Value;
            string role = context.User.FindFirst(ClaimTypes.Role).Value;

            return new AuthUser(id, email, firstName, lastName, role);
        }
    }
}

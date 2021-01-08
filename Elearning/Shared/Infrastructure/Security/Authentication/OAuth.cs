using elearning.Shared.Domain;
using elearning.Shared.Infrastructure.Security.Authentication.JWT;

namespace elearning.Shared.Infrastructure.Security.Authentication
{
    public class OAuth
    {
        private IJWTDecoder JWTDecoder;

        public OAuth(IJWTDecoder JWTDecoder)
        {
            this.JWTDecoder = JWTDecoder;
        }

        public AuthUser User()
        {
            return JWTDecoder.Decode();
        }
    }
}

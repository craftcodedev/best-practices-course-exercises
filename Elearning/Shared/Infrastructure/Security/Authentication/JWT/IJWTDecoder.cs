using elearning.Shared.Domain;

namespace elearning.Shared.Infrastructure.Security.Authentication.JWT
{
    public interface IJWTDecoder
    {
        AuthUser Decode();
    }
}
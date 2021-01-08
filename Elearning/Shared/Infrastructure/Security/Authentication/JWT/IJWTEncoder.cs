using elearning.IAM.Token.Domain;

namespace elearning.Shared.Infrastructure.Security.Authentication.JWT
{
    public interface IJWTEncoder
    {
        string Encode(Payload payload);
    }
}
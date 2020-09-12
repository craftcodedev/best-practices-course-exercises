using System.Collections.Generic;

namespace BlockbusterApp.src.Shared.Infrastructure.Security.Authentication.JWT
{
    public interface IJWTEncoder
    {
        string Encode(Dictionary<string, string> payload);
    }
}
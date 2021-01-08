using elearning.IAM.User.Domain;

namespace elearning.Shared.Infrastructure.Service.Hashing
{
    public interface IHashing
    {
        UserHashedPassword Hash(string password);
    }
}
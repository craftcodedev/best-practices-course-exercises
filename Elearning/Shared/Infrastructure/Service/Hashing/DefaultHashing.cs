using System.Security.Cryptography;
using System.Text;
using System;
using elearning.IAM.User.Domain;

namespace elearning.Shared.Infrastructure.Service.Hashing
{
    public class DefaultHashing : IHashing
    {
        public UserHashedPassword Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;

            using (var algorithm = new SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            string hash = Convert.ToBase64String(hashBytes);

            return new UserHashedPassword(hash);
        }
    }
}
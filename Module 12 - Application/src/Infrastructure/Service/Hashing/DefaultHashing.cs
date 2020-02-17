using System;
using System.Text;
using System.Security.Cryptography;

namespace App.Infrastructure.Service.Hashing
{
    public class DefaultHashing : IHashing
    {
        public string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            
            using (var algorithm = new SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }

            return Convert.ToBase64String(hashBytes);
        }
    }
}
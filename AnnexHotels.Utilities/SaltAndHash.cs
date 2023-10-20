using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AnnexHotels.Utilities
{
    public static class SaltAndHash
    {
        public static string SaltHashedPassword(string password, string salt)
        {
            var sha = SHA256.Create();
            var saltedPassword = password + salt;

            return Convert.ToBase64String(sha
                .ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));
        }

        public static string Salt()
        {
            var rng = RandomNumberGenerator.Create();
            var saltBytes = new byte[16];
            rng.GetBytes(saltBytes);

            return Convert.ToBase64String(saltBytes);
        }
    }
}

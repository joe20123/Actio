using System;
using System.Security.Cryptography;

namespace Actio.Services.Identity.Domain.Services
{
    public class Encryptor : IEncryptor
    {
        private static readonly int SaltSize = 40;
        private static readonly int DeriveBytesIterationsCount = 1000;
        public string GetHash(string value, string salt)
        {
            var pk = new Rfc2898DeriveBytes(value, GetBytes(salt), DeriveBytesIterationsCount);
            return Convert.ToBase64String(pk.GetBytes(SaltSize));        
        }

        public string GetSalt(string value)
        {
            var random = new Random();
            var saltBytes = new byte[SaltSize];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(saltBytes);
            return Convert.ToBase64String(saltBytes);
        }

        private static byte[] GetBytes(string value)
        {
            var bytes = new byte[value.Length*sizeof(char)];
            Buffer.BlockCopy(value.ToCharArray(),0,bytes,0, bytes.Length);
            return bytes;
        }
    }
}
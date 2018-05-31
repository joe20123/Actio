namespace Actio.Services.Activities.Domain.Services
{
    public interface IEncryptor
    {
         string GetSalt(string value);
         string GetHash(string value, string salt);
    }
}
using System;
using Actio.Services.Identity.Domain.Services;

public class User {

    protected User()
    {     
    }
    public User(string email, string name )
    {
        // TODO: validate code
        Id    = Guid.NewGuid();
        Email = email.ToLowerInvariant();
        name  = name.ToLowerInvariant();
        CreatedAt = DateTime.UtcNow;
    }

    public Guid Id { get; protected set; }
    public string Email { get; protected set; }
    public string Name { get; protected set; }
    public string Password { get; protected set; }
    public string Salt { get; protected set; }
    public DateTime CreatedAt { get; set; }

    public void SetPassword(string password, IEncryptor encryptor)
    {
        //TODO: validate
        if (string.IsNullOrWhiteSpace(password))
        {
            return;
        }
        Salt = encryptor.GetSalt(password);
        Password = encryptor.GetHash(password, Salt);
    }

    public bool ValidatePassword(string password, IEncryptor encryptor)
        => Password.Equals(encryptor.GetHash(password, Salt));

           
}
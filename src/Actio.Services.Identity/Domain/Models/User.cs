using System;

public class User {

    protected User()
    {     
    }
    public User(string email, string name )
    {
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
}
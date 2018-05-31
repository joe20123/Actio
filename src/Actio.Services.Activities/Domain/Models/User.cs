using System;

namespace Actio.Services.Activities.Domain.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string email, string name)
        {
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            Name = name;
            CreatedAt = DateTime.UtcNow;
        }

        public System.Guid Id { get ;protected set; }     
        public string Email { get; protected set; }
        public string Name { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public DateTime CreatedAt { get; protected set; } 
    }
}
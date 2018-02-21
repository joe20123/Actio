using System;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid UserId { get; }

        public Guid Id { get;  }
        public string Category { get;  }
        public string Name { get;  }
        public string Description { get;  }
        public DateTime CreatedAt { get;  }  

        protected ActivityCreated()
        {
        }   

        public ActivityCreated  (Guid id, Guid useId, string category, string name,
            string description)
        {
            Id=id;
            UserId = useId;
            Category= category;
            Name= name;
            Description = description;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
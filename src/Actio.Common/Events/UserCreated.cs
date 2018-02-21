namespace Actio.Common.Events
{
    public class UserCreated
    {
        public string Email {get; }
        public string Name { get; }

        protected UserCreated()
        {
        }
        public UserCreated(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}
namespace Actio.Common.Events
{
    public class CreateUserRejected : IRegectedEvent
    {
        public string Reason { get; }

        public string Code { get; }

        public string Email { get; }

        protected CreateUserRejected()
        {
        }

        public CreateUserRejected(string email, string reason, string code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }

    }
}
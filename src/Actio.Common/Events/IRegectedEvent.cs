namespace Actio.Common.Events
{
    public interface IRegectedEvent : IEvent
    {
         string Reason { get; }
         string Code { get; }
    }
}
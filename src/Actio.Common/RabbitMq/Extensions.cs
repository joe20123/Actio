using System.Threading.Tasks;
using Actio.Common.Commands;
using RawRabbit;
using RawRabbit.Pipe;

namespace Actio.Common.RabbitMq
{
    public static class Extensions
    {
        // public static Task WithCommandHandlerAsync<TCommand>(this IBusClient bus,
        //     ICommandHandler<TCommand> handler) where TCommand: ICommand
        //     => bus.SubscribeAsync<TCommand>(msg => handler.HandleAsync(msg),
        //     ctx => ctx.UseConsumerConfiguration(cfg => cfg.FromDeclaredQueue(q => q.WithName())))
    }
}
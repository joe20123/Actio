using System;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Actio.Common.Events;
using RawRabbit;

namespace Actio.Services.Activities.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _client;
        public CreateActivityHandler(IBusClient client)
        {
            _client = client;

        }
        public async Task HandleAsync(CreateActivity command)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Creating Activity: {command.Name}");
            await _client.PublishAsync(new ActivityCreated(command.Id, command.UserId,
             command.Category, command.Name, command.Description));
        }
    }
}
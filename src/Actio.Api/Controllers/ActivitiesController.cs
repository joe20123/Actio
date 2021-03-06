using System;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Actio.Api.Controllers
{
    [Route("[controller")]
    public class ActivitiesController : Controller
    {
        private IBusClient _busClient;
        public ActivitiesController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateActivity command)
        {
            command.CreatedAt = DateTime.UtcNow;
            command.Id = Guid.NewGuid();

            await _busClient.PublishAsync(command);

            return Accepted($"activities/{command.Id}");
        }
    }
}
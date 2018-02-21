// using System;
// using Microsoft.AspNetCore;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Configuration;

// namespace Actio.Common.Services
// {
//     public class ServiceHost : IServiceHost
//     {

//         private readonly IWebHost _webHost;
//         public ServiceHost(IWebHost webhost)
//         {
//             _webHost = webhost;
//         }

//         public void Run() => _webHost.Run();
       
//         public static HostBuilder Create<TStartup>(string[] args) where TStartup : class
//         {
//             Console.Title = typeof(TStartup).Namespace;
//             var config = new ConfigurationBuilder()
//                 .AddEnvironmentVariables()
//                 .AddCommandLine(args)
//                 .Build();
//             var webHostBuilder = WebHost.CreateDefaultBuilder(args)
//                 .UseConfiguration(config)
//                 .UseStartup<TStartup>();
//             return new HostBuilder(webHostBuilder.Build());   
//         }

//         public abstract class BuilderBase
//         {
//             public abstract ServiceHost Build();
//         }

//         public class HostBuilder : BuilderBase
//         {
//             private readonly IWebHost _webHost;
//             private IBusClient _bus;

//             public HostBuilder(IWebHost webHost)
//             {
//                 _webHost = webHost;
//             }

//             public BusBuilder UseRabbitMq()
//             {
//                 _bus = _webHost.Services.GetService(typeof(IBusClient));
//                 return new BusBuilder(_webHost, _bus);
//             }

//             public override ServiceHost Build()
//             {
//                 return new ServiceHost(_webHost);
//             }
//         }

//         public class BusBuilder: BuilderBase 
//         {
//             private readonly IWebHost _webHost;
//             private IBusClient _bus;  
//             public BusBuilder(IWebHost webHost, IBusClient bus)
//             {
//                 _webHost = webHost;
//                 _bus = bus;
//             }         
//         }
//     }
// }
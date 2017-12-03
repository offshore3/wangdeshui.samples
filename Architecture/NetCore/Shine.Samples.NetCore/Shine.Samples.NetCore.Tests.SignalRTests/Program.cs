using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;

namespace Shine.Samples.NetCore.Tests.SignalRTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Hello();
            Console.ReadLine();

        }

        private static async Task Hello()
        {
            HubConnection hubConnection = await ConnectAsync("http://localhost:54358/hello");

            
            hubConnection.On<string>("Hello", data =>
            {
                Console.WriteLine(data);
            });

            hubConnection.Closed += HubConnection_Closed;
        }

        private static Task HubConnection_Closed(Exception arg)
        {
            throw new NotImplementedException();
        }

        private static async Task<HubConnection> ConnectAsync(string baseUrl)
        {
            // Keep trying to until we can start
            while (true)
            {
                var connection = new HubConnectionBuilder()
                    .WithUrl(baseUrl)
                    .WithConsoleLogger(LogLevel.Trace)
                    .Build();
                try
                {
                    await connection.StartAsync();
                    return connection;
                }
                catch (Exception)
                {
                    await Task.Delay(1000);
                }
            }
        }
    }
}

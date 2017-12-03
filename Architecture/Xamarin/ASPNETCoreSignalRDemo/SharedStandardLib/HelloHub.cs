using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Logging;

namespace SharedStandardLib
{
    public class HelloHub
    {
        private HubConnection _hubConnection;
        
        public async void Start()
        {
            _hubConnection = await ConnectAsync("http://localhost:54358/hello");


            _hubConnection.On<string>("Hello", data =>
            {
                Console.WriteLine(data);
            });

            _hubConnection.Closed += HubConnection_Closed;
        }


        public async void Close()
        {
           await  _hubConnection.DisposeAsync();
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

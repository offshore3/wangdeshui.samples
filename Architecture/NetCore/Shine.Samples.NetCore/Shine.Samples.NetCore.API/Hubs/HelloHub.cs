using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Shine.Samples.NetCore.ApplicationServices.Interfaces;

namespace Shine.Samples.NetCore.API.Hubs
{
    public class HelloHub:Hub
    {
        private readonly IProjectApplicationService _projectApplicationService;

        public HelloHub(IProjectApplicationService projectApplicationService)
        {
            _projectApplicationService = projectApplicationService;
        }
        public async Task Hello(string message)
        {

            await Clients.All.InvokeAsync("Hello", DateTime.UtcNow.ToString());
        }

        public Task Subscribe(int matchId)
        {

            return Groups.AddAsync(Context.ConnectionId, matchId.ToString());
        }

        public Task Unsubscribe(int matchId)
        {
            return Groups.RemoveAsync(Context.ConnectionId, matchId.ToString());
        }

        public override Task OnConnectedAsync()
        {
          
            return base.OnConnectedAsync();
        }

    }
}

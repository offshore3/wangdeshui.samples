using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Shine.Samples.API.Hubs
{
    public class ServerTimeHub : Hub
    {
        public string GetServerTime()
        {
            return DateTime.UtcNow.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace backend.Hubs
{
    public class CommandsHub : Hub
    {
        public async Task SendCommand(string key, bool right_value, bool left_value)
        {

            await Clients.All.SendAsync("ReceiveMessage", key, right_value,left_value);
        }
    }
}

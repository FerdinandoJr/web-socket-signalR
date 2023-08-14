using Microsoft.AspNetCore.SignalR;
using System.Web;
using System;

namespace web_socket_signalR.Hubs
{
    public class WebSocketHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine("SERVIDOR RECEBEU!");

            await Clients.All.SendAsync("ReceiveMessage", user, message);

        }
    }
}

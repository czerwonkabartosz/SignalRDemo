using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRDemo.Hubs
{
    [HubName("DemoHub")]
    public class DemoHub : Hub
    {
        public string Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
            return null;
        }
    }
}
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.GT.SmartOffice.Models;

namespace SignalRHub
{
    [HubName("GTHub")]
    public class GTHub : Hub
    {
        public void DetermineLength(string message)
        {
            Console.WriteLine(message);

            string newMessage = "response : "+message ;
            Clients.All.ReceiveLength(newMessage);
        }
    }
}

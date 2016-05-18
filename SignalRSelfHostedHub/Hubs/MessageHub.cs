using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignalRSelfHostedHub.Models;

namespace SignalRSelfHostedHub.Hubs
{
    public class MessageHub : Hub
    {
        [HubMethodName("sendMessage")]
        public static void Send(MessageModels model)
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MessageHub>();
            context.Clients.All.sendMessage(model);
            //Clients.All.addMessage(name, message);
        }
    }
}
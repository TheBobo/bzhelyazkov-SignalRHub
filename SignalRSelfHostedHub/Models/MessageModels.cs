using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRSelfHostedHub.Models
{
    public class MessageModels
    {
        public string Message { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
    }
}
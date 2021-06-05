using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Server.Notifications
{
    public class Notification1:INotification
    {
        public string Message { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Server.Notifications;

namespace Server.NotificationsHandler
{
    public class Notification1Handler:INotificationHandler<Notification1>
    {
        public async Task Handle(Notification1 notification, CancellationToken cancellationToken)
        {
            var messgae = "";
            await Task.Run(() =>
            {
                messgae = ToString() + "---" + notification.Message.ToUpper();
                Console.WriteLine(messgae);
            });
        }
    }
}

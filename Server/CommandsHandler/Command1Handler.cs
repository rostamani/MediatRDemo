using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Server.Commands;

namespace Server.CommandsHandler
{
    public class Command1Handler:RequestHandler<Command1>
    {
        protected override void Handle(Command1 request)
        {
            var message = request.Message.ToUpper();
            Console.WriteLine(message);
        }
    }
}

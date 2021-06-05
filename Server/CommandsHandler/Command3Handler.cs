using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Server.Commands;

namespace Server.CommandsHandler
{
    public class Command3Handler : RequestHandler<Command3, string>
    {
        protected override string Handle(Command3 request)
        {
            var message = request.Message.ToUpper();
            Console.WriteLine(message);
            return message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Server.Commands;

namespace Server.CommandsHandler
{
    public class Command2Handler:IRequestHandler<Command2>

    {
        public async Task<Unit> Handle(Command2 request, CancellationToken cancellationToken)
        {
            await Task.Run(() =>
            {
                var message = request.Message.ToUpper();
                Console.WriteLine(message);
            });

            return new Unit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Server.Commands;

namespace Server.CommandsHandler
{
    public class Command4Handler : IRequestHandler<Command4, string>
    {
        public async Task<string> Handle(Command4 request, CancellationToken cancellationToken)
        {

            var message = "";
            await Task.Run(() =>
            {
                message = request.Message.ToUpper();
                Console.WriteLine(message);
            });

            return message;

        }
    }
}

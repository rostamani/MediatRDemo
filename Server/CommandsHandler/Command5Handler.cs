using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentResults;
using MediatR;
using Server.Commands;

namespace Server.CommandsHandler
{
    public class Command5Handler : IRequestHandler<Command5, Result>
    {
        public async Task<Result> Handle(Command5 request, CancellationToken cancellationToken)
        {
            var result = new Result<string>();
            await Task.Run(() =>
            {
                result.WithError("Error in command 5 . ");
            });

            return result;
        }

    }
}

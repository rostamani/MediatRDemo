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
    public class Command6Handler:IRequestHandler<Command6,Result<string>>
    {
        public async Task<Result<string>> Handle(Command6 request, CancellationToken cancellationToken)
        {
            var result=new Result<string>();
            await Task.Run(() =>
            {
                result.WithValue(request.Message.ToUpper());
            });

            return result;
        }
    }
}

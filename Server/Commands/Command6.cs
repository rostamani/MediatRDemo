using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentResults;
using MediatR;

namespace Server.Commands
{
    public class Command6 : IRequest<Result<string>>
    {
        public string Message { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Server.Commands
{
    public class Command2:IRequest
    {
        public string Message { get; set; }
    }
}

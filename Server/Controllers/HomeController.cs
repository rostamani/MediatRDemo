using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Server.Commands;
using Server.Notifications;

namespace Server.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok("MediateR is running ...");
        }

        [HttpGet]
        public async Task<IActionResult> Test1()
        {
            var command1 = new Command1()
            {
                Message = "Command one ."
            };
            await _mediator.Send(command1);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Test2()
        {
            var command2 = new Command2()
            {
                Message = "Command two ."
            };
            await _mediator.Send(command2);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Test3()
        {
            var command3 = new Command3()
            {
                Message = "Command three ."
            };
            var result=await _mediator.Send(command3);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Test4()
        {
            var command4 = new Command4()
            {
                Message = "Command four ."
            };
            var result=await _mediator.Send(command4);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Test5()
        {
            var command5 = new Command5()
            {
                Message = "Command five ."
            };
            var result = await _mediator.Send(command5);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Test6()
        {
            var command6 = new Command6()
            {
                Message = "Command six ."
            };
            var result = await _mediator.Send(command6);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.ToResult());
            }
        }

        [HttpGet]
        public async Task<IActionResult> Test7()
        {
            var notification1 = new Notification1()
            {
                Message = "Notification One ."
            };
            await _mediator.Publish(notification1);
            return Ok();
        }
    }
}

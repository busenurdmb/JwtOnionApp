using MediatR;
<<<<<<< HEAD
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers;
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries;
using UdemyJwtApp.Back.Infrastructure.Tools;

namespace UdemyJwtApp.Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserCommandRequest request)
        {
            await _mediator.Send(request);
<<<<<<< HEAD
<<<<<<< HEAD
            return Created("", request);
=======
            return Created("",request);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            return Created("",request);
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login(CheckUserQueryRequest request)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var dto = await _mediator.Send(request);
            if (dto.IsExist)
            {
                return Created("", JwtTokenGenerator.GenerateToken(dto));
=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
          var dto=  await _mediator.Send(request);
            if(dto.IsExist)
            {
             return Created("", JwtTokenGenerator.GenerateToken(dto));
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            }
            else
            {
                return BadRequest("kullanıcı adı veya şifre hatalı");
            }

        }
    }
}

using MediatR;
using Onion.JwtApp.Application.Dto;

namespace Onion.JwtApp.Application.Features.CQRS.Commands
{
    public class RegisterUserCommandRequest : IRequest<CreatedUserDto?>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}

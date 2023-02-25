using MediatR;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class RegisterUserCommandRequest : IRequest
=======
    public class RegisterUserCommandRequest:IRequest
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
    public class RegisterUserCommandRequest:IRequest
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}

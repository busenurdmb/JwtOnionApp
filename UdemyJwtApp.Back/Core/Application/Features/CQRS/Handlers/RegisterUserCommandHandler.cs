using MediatR;
using UdemyJwtApp.Back.Core.Application.Enums;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public RegisterUserCommandHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            await _repository.CreateAsync(new AppUser
=======
          await  _repository.CreateAsync(new AppUser
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
          await  _repository.CreateAsync(new AppUser
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            {
                Username = request.Username,
                Password = request.Password,
                AppRoleId = (int)RoleType.Member,
            });
            return Unit.Value;
        }
    }
}

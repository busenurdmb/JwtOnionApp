using AutoMapper;
using MediatR;
using Onion.JwtApp.Application.Dto;
using Onion.JwtApp.Application.Enum;
using Onion.JwtApp.Application.Features.CQRS.Commands;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest, CreatedUserDto?>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;



        public RegisterUserCommandHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreatedUserDto?> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            var user = new AppUser() { Username = request.Username, Password = request.Password, AppRoleId = (int)RoleType.Member };
            await _repository.CreateAsync(user);
            return _mapper.Map<CreatedUserDto>(user);


        }
    }
}

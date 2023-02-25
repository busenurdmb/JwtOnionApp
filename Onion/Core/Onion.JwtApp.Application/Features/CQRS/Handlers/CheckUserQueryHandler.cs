using MediatR;
using Onion.JwtApp.Application.Dto;
using Onion.JwtApp.Application.Features.CQRS.Queries;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers
{
    public class CheckUserQueryHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IRepository<AppUser> _userrepository;
        private readonly IRepository<AppRole> _rolerepository;

        public CheckUserQueryHandler(IRepository<AppUser> userrepository, IRepository<AppRole> rolerepository)
        {
            _userrepository = userrepository;
            _rolerepository = rolerepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user = await _userrepository.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);
            if (user == null)
            {
                dto.IsExist = false;
            }
            else
            {
                dto.IsExist = true;
                dto.Username = request.Username;
                dto.Role = (await _rolerepository.GetByFilterAsync(x => x.Id == user.AppRoleId))?.Definition;
                dto.Id = user.Id;
            }
            return dto;

        }
    }
}

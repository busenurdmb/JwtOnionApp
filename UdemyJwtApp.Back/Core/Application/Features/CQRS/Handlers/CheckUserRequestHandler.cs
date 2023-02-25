using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using UdemyJwtApp.Back.Core.Application.Enums;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
using UdemyJwtApp.Back.Core.Application.Enums;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class CheckUserRequestHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IRepository<AppUser> _userrepository;
        private readonly IRepository<AppRole> _rolerepository;

        public CheckUserRequestHandler(IRepository<AppUser> userrepository, IRepository<AppRole> rolerepository)
        {
            _userrepository = userrepository;
            _rolerepository = rolerepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var dto = new CheckUserResponseDto();
=======
            var dto=new CheckUserResponseDto();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            var dto=new CheckUserResponseDto();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            var user = await _userrepository.GetByFilterAsync(x => x.Username == request.Username && x.Password == request.Password);
            if (user == null)
            {
                dto.IsExist = false;
            }
            else
            {
<<<<<<< HEAD
<<<<<<< HEAD
                dto.Username = user.Username;
                dto.Id = user.Id;
                dto.IsExist = true;
=======
                dto.Username= user.Username;
                dto.Id = user.Id;
                dto.IsExist= true;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
                dto.Username= user.Username;
                dto.Id = user.Id;
                dto.IsExist= true;
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                var role = await _rolerepository.GetByFilterAsync(x => x.Id == user.AppRoleId);
                dto.Role = role?.Definition;
            }
            return dto;
        }
    }
}

using AutoMapper;
using Onion.JwtApp.Application.Dto;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Mappings
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUser, CreatedUserDto>().ReverseMap();
        }
    }
}

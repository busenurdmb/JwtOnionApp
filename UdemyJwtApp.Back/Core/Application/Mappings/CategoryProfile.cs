using AutoMapper;
using UdemyJwtApp.Back.Core.Application.Dto;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            this.CreateMap<Category, CategoryListDto>().ReverseMap();
=======
            this.CreateMap<Category,CategoryListDto>().ReverseMap();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            this.CreateMap<Category,CategoryListDto>().ReverseMap();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
    }
}

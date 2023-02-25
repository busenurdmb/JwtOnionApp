using AutoMapper;
using UdemyJwtApp.Back.Core.Application.Dto;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            this.CreateMap<Product, ProductListDto>().ReverseMap();
=======
            this.CreateMap<Product,ProductListDto>().ReverseMap(); 
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            this.CreateMap<Product,ProductListDto>().ReverseMap(); 
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
    }
}

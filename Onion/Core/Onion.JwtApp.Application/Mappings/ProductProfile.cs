using AutoMapper;
using Onion.JwtApp.Application.Dto;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductListDto>().ReverseMap();
            CreateMap<Product, CreatedProductDto>().ReverseMap();
        }
    }
}

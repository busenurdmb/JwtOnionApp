using AutoMapper;
using MediatR;
using Onion.JwtApp.Application.Dto;
using Onion.JwtApp.Application.Features.CQRS.Queries;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var productlist = await _repository.GetAllAsync();
            return _mapper.Map<List<ProductListDto>>(productlist);
            throw new NotImplementedException();
        }
    }
}

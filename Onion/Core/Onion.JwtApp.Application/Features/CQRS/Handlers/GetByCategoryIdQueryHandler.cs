using AutoMapper;
using MediatR;
using Onion.JwtApp.Application.Dto;
using Onion.JwtApp.Application.Features.CQRS.Queries;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers
{
    public class GetByCategoryIdQueryHandler : IRequestHandler<GetByCategoryIdQueryRequest, CategoryListDto?>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetByCategoryIdQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        public async Task<CategoryListDto?> Handle(GetByCategoryIdQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await _repository.GetByFilterAsync(x => x.Id == request.Id);
            return _mapper.Map<CategoryListDto>(list);
        }
    }
}

using AutoMapper;
using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQueryRequest, ProductListDto?>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductListDto?> Handle(GetProductQueryRequest request, CancellationToken cancellationToken)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var data = await _repository.GetByFilterAsync(x => x.Id == request.Id);
            return _mapper.Map<ProductListDto>(data);

=======
            var data=await _repository.GetByFilterAsync(x=>x.Id==request.Id);
            return _mapper.Map<ProductListDto>(data);
            
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            var data=await _repository.GetByFilterAsync(x=>x.Id==request.Id);
            return _mapper.Map<ProductListDto>(data);
            
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
    }
}

using AutoMapper;
using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, List<CategoryListDto>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetAllCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var data = await _repository.GetAllAsync();
=======
          var data=  await _repository.GetAllAsync();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
          var data=  await _repository.GetAllAsync();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            return _mapper.Map<List<CategoryListDto>>(data);
        }
    }
}

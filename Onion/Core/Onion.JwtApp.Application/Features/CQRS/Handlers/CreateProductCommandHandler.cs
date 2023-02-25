using AutoMapper;
using MediatR;
using Onion.JwtApp.Application.Dto;
using Onion.JwtApp.Application.Features.CQRS.Commands;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreatedProductDto?>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreatedProductDto?> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = new Product { Name = request.Name, Stock = request.Stock, Price = request.Price, CategoryId = request.CategoryId };
            var added = await _repository.CreateAsync(product);
            return _mapper.Map<CreatedProductDto>(added);

        }
    }
}

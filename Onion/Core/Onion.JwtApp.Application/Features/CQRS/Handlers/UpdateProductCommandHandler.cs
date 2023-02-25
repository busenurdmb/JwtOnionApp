using MediatR;
using Onion.JwtApp.Application.Features.CQRS.Commands;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedEntity = await _repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.Stock = request.Stock;
                updatedEntity.Price = request.Price;
                updatedEntity.Name = request.Name;
                updatedEntity.CategoryId = request.CategoryId;
                //  await _repository.UpdateAsync(updatedEntity);
                //connected entity ile çalıştığım için uptadeti çağrımamam gerek yok
                await _repository.SaveChangesAsync();

            }
            return Unit.Value;

        }
    }
}

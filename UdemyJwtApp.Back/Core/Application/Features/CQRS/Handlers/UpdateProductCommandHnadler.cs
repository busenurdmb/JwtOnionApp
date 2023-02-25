using MediatR;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommandHnadler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHnadler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {

            var updatedProduct = await _repository.GetByIdAsync(request.Id);
            if (updatedProduct != null)
            {
                updatedProduct.CategoryId = request.CategoryId;
<<<<<<< HEAD
<<<<<<< HEAD
                updatedProduct.Price = request.Price;
                updatedProduct.Stock = request.Stock;
                updatedProduct.Name = request.Name;
                await _repository.UpdateAsync(updatedProduct);

=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
                updatedProduct.Price= request.Price;
                updatedProduct.Stock= request.Stock;
                updatedProduct.Name= request.Name;
                await _repository.UpdateAsync(updatedProduct);
                    
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            }
            return Unit.Value;
        }
    }
}

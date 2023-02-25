using MediatR;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public DeleteProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var data = await _repository.GetByIdAsync(request.Id);
            if (data != null)
            {
                await _repository.RemoveAsync(data);

            }
            return Unit.Value;

=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            var data =await _repository.GetByIdAsync(request.Id);
            if (data != null)
            {
                await _repository.RemoveAsync(data);
           
            }
             return Unit.Value;
            
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
    }
}

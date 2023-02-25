using MediatR;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest>
    {
        private readonly IRepository<Category> _repository;

        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Category
            {
                Definition = request.Definition
            });
            return Unit.Value;
<<<<<<< HEAD
<<<<<<< HEAD

=======
            
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }
    }
}

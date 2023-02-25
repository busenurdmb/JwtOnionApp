using MediatR;
using UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Domain;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest>
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            var updadeEntity = await _repository.GetByIdAsync(request.Id);
            if (updadeEntity != null)
=======
            var updadeEntity=await _repository.GetByIdAsync(request.Id);
            if (updadeEntity!=null)
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
            var updadeEntity=await _repository.GetByIdAsync(request.Id);
            if (updadeEntity!=null)
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
            {
                updadeEntity.Definition = request.Definition;
                await _repository.UpdateAsync(updadeEntity);
            }
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

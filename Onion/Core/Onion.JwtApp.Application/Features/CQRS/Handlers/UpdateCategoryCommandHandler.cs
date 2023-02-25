using MediatR;
using Onion.JwtApp.Application.Features.CQRS.Commands;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Domain.Entities;

namespace Onion.JwtApp.Application.Features.CQRS.Handlers
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
            //1->entity entry state=> modified olarak setliyorum
            //2->
            //Update() ?

            //Connected Entity
            //biz bir ıd değeri ile bir entityi yakaladığımızda connected


            var updatedEntity = await _repository.GetByIdAsync(request.Id);
            if (updatedEntity != null)
            {
                updatedEntity.Definition = request.Definition; //1-modified
                                                               //    await _repository.UpdateAsync(updatedEntity);//modified=>modified
                await _repository.SaveChangesAsync();
            }



            //Disconnected Entity 
            //var updatedCategory = new Category()
            //{
            //    Definition = request.Definition,
            //    Id = request.Id,
            //};
            //sen bir tane category nesnesi koyuyorsun bana bu catgory nesnesinin içinde bir ıd bir definition alanı var ben bakıcam bu ıd dolumu değilmi bu ıd dolusa ben bunun state modified olarak setlicem değilse added olarak setlicem 
            //await _repository.UpdateAsync(updatedCategory);
            //await _repository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}

using MediatR;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class DeleteCategoryCommandRequest : IRequest
=======
    public class DeleteCategoryCommandRequest:IRequest
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
    public class DeleteCategoryCommandRequest:IRequest
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
    {
        public int Id { get; set; }

        public DeleteCategoryCommandRequest(int id)
        {
            Id = id;
        }
    }
}

using MediatR;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class UpdateProductCommandRequest : IRequest
=======
    public class UpdateProductCommandRequest:IRequest
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
    public class UpdateProductCommandRequest:IRequest
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}

using MediatR;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Commands
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class CreateProductCommandRequest : IRequest
=======
    public class CreateProductCommandRequest:IRequest
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
    public class CreateProductCommandRequest:IRequest
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}

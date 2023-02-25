using MediatR;
using Onion.JwtApp.Application.Dto;

namespace Onion.JwtApp.Application.Features.CQRS.Commands
{
    public class CreateProductCommandRequest : IRequest<CreatedProductDto?>
    {
        public string? Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}

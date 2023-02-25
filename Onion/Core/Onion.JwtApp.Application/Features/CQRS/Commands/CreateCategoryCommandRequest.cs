using MediatR;
using Onion.JwtApp.Application.Dto;

namespace Onion.JwtApp.Application.Features.CQRS.Commands
{
    public class CreateCategoryCommandRequest : IRequest<CreatedCategoryDto?>
    {
        public string? Definiton { get; set; }
    }
}

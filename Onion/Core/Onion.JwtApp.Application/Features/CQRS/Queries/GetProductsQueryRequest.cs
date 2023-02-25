using MediatR;
using Onion.JwtApp.Application.Dto;

namespace Onion.JwtApp.Application.Features.CQRS.Queries
{
    public class GetProductsQueryRequest : IRequest<List<ProductListDto>>
    {
    }
}

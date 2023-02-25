using MediatR;
using Onion.JwtApp.Application.Dto;

namespace Onion.JwtApp.Application.Features.CQRS.Queries
{
    public class GetByCategoryIdQueryRequest : IRequest<CategoryListDto?>
    {
        public int Id { get; set; }

        public GetByCategoryIdQueryRequest(int id)
        {
            Id = id;
        }
    }
}

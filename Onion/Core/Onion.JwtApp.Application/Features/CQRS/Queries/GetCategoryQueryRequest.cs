using MediatR;
using Onion.JwtApp.Application.Dto;

namespace Onion.JwtApp.Application.Features.CQRS.Queries
{
    public class GetCategoryQueryRequest : IRequest<List<CategoryListDto>>
    {
        /*mediatR Pattern
          hangi query karşılık hangi handler çalıştıracağımızı İnterfaceler aracılığıyla belirleyen pattern
         
         
         
         */
    }
}

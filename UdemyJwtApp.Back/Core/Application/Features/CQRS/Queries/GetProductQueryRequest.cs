using MediatR;
using UdemyJwtApp.Back.Core.Application.Dto;

namespace UdemyJwtApp.Back.Core.Application.Features.CQRS.Queries
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class GetProductQueryRequest : IRequest<ProductListDto?>
=======
    public class GetProductQueryRequest:IRequest<ProductListDto?>
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
    public class GetProductQueryRequest:IRequest<ProductListDto?>
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
    {
        public int Id { get; set; }

        public GetProductQueryRequest(int id)
        {
            Id = id;
        }
    }
}

﻿using MediatR;
using Onion.JwtApp.Application.Dto;

namespace Onion.JwtApp.Application.Features.CQRS.Queries
{
    public class GetProductQueryRequest : IRequest<ProductListDto?>
    {
        public int Id { get; set; }

        public GetProductQueryRequest(int id)
        {
            Id = id;
        }
    }
}

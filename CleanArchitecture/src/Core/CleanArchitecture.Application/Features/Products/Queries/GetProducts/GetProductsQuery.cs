using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Features.Products.DTOs;
using MediatR;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Features.Products.Queries.GetProducts
{
    public class GetProductsQuery : IRequest<PaginatedList<ProductDto>>
    {
        
    }


}
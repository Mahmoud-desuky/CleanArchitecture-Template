using AutoMapper;
using CleanArchitecture.Application.Common.Mappings;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.Products.DTOs;

public class ProductDto : IMapFrom<Product>
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<Product, ProductDto>();
    }
}

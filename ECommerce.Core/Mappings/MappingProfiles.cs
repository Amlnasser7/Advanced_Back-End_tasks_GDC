using AutoMapper;
using ECommerce.Application.DTOs;
using ECommerce.Core.Entities;

namespace ECommerce.Application.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {

            CreateMap<Product, ProductDto>()

                .ForMember(d => d.BrandName, o => o.MapFrom(s => s.ProductBrand.Name))
                

                .ForMember(d => d.TypeName, o => o.MapFrom(s => s.ProductType.Name));
            
            
            CreateMap<ProductBrand, BrandDto>();

            
            CreateMap<ProductType, TypeDto>();
        }
    }
}
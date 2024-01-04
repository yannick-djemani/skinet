using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
            .ForMember(p=>p.ProductBrand, o=>o.MapFrom(s=>s.ProductBrand.Name))
            .ForMember(p=>p.ProductType, o=>o.MapFrom(s=>s.ProductType.Name))
            .ForMember(d=>d.PictureUrl, o=>o.MapFrom<ProductUrlResolver>());
        }
    }
}
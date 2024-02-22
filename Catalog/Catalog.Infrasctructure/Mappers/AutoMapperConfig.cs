using AutoMapper;
using Catalog.Core.Domain;
using Catalog.Infrasctructure.DTO;

namespace Catalog.Infrasctructure.Mappers
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}

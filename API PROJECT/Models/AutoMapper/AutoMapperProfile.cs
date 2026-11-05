using AutoMapper;

namespace API_PROJECT.Models.AutoMapper
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}

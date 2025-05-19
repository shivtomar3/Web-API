using AutoMapper;
using WebApiWithEfcore.Model;

namespace WebApiWithEfcore.AutoMapper
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<ProductDTO, ProductEntity>().ReverseMap();
        }
       

    }
}

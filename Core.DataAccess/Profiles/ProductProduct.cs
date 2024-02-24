using Core.DataAccess.Contracts.Model;
using Core.DataAccess.Entities;
using Core.Utils;

namespace Core.DataAccess.Profiles;

public class ProductProduct : MapperProfile
{
    public ProductProduct()
    {
        CreateMap<ProductEntity, ProductDto>()
            .ForMember(dest => dest.Id,
                opt
                    => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name,
                opt
                    => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Price,
                opt
                    => opt.MapFrom(src => src.Price))
            .ReverseMap();
    }
}
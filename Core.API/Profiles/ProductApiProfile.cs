using Core.API.Request;
using Core.API.Response;
using Core.Utils;

namespace Core.API.Profiles;

public class ProductsApiProfile : MapperProfile
{
    public ProductsApiProfile()
    {
        CreateMap<AddProductRequest, ProductResponse>();
    }
}

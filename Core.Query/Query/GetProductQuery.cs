using Core.DataAccess.Contracts.Model;
using Core.Query.Contracts.Base;

namespace Core.Query.Query;

public class GetProductQuery : IQuery<ProductDto>
{
    public int Id { get; set; }

    public GetProductQuery(int id)
    {
        Id = id;
    }
}
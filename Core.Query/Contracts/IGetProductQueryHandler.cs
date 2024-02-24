using Core.DataAccess.Contracts.Model;
using Core.Query.Contracts.Base;
using Core.Query.Query;

namespace Core.Query.Contracts;

public interface IGetProductQueryHandler : IQueryHandler<GetProductQuery, ProductDto?>
{
    
}
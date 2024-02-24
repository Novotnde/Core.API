using Core.DataAccess.Contracts;
using Core.DataAccess.Contracts.Model;
using Core.Query.Contracts;
using Core.Query.Query;


namespace Core.Query.QueryHandler
{
    public class GetProductQueryHandler : IGetProductQueryHandler
    {
        IProductRepository _productRepository;
        public GetProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public async Task<ProductDto?> HandleAsync(GetProductQuery query)
        {
            var result = await _productRepository.GetProductByIdAsync(query.Id);
            return result;
        }
    }
}
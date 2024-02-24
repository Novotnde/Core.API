using Core.DataAccess.Contracts.Model;

namespace Core.DataAccess.Contracts;

public interface IProductRepository
{
    Task AddProductAsync(ProductDto product);
    
    Task <ProductDto?> GetProductByIdAsync(int productId);
}
using AutoMapper;
using Core.DataAccess.Contracts;
using Core.DataAccess.Contracts.Model;
using Core.DataAccess.Data;
using Core.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Repository;

public class ProductRepository : IProductRepository
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    
    public ProductRepository(DataContext context, IMapper mapper)
    {
        this._context = context;
        this._mapper = mapper;
    }  

    public async Task AddProductAsync(ProductDto product)
    {
        var productEntity = _mapper.Map<ProductDto, ProductEntity>(product);
        _context.Product.Add(productEntity);
        await _context.SaveChangesAsync();
    }

    public async Task<ProductDto?> GetProductByIdAsync(int productId)
    {
        var product = await _context.Product.FirstOrDefaultAsync(p => p.Id == productId)!;
        if (product == null) return null;
        var productDto = _mapper.Map<ProductEntity, ProductDto>(product);
        return productDto;
    }
}
using Core.Commands.Command;
using Core.Commands.Contracts;
using Core.DataAccess.Contracts;
using Core.DataAccess.Contracts.Model;

namespace Core.Commands.CommandHandler;

public class AddProductCommandHandler : IAddProductCommandHandler
{
    private readonly IProductRepository _productRepository;

    public AddProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task HandleAsync(AddProductCommand command)
    {
        var product = new ProductDto
        {
            Name = command.Name,
            Description = command.Description,
            Price = command.Price,
            PictureUrl = command.PictureUrl
        };

       await _productRepository.AddProductAsync(product);
    }
}

    

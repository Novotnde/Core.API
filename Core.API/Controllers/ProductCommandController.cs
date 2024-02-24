using AutoMapper;
using Core.API.Request;
using Core.API.Response;
using Core.Commands.Command;
using Core.Commands.Contracts;
using Core.Query.Contracts;
using Core.Query.Query;
using Microsoft.AspNetCore.Mvc;

namespace Core.API.Controllers;

[Route("api/[controller]")]

public class ProductCommandController : Controller
{
    private readonly IAddProductCommandHandler _addProductCommandHandler;
    private readonly IGetProductQueryHandler _getProductQueryHandler;
    private readonly IMapper _mapper;
    
    public ProductCommandController(
        IAddProductCommandHandler addProductCommandHandler,
        IGetProductQueryHandler getProductQueryHandler, IMapper mapper)
    {
        _addProductCommandHandler = addProductCommandHandler ?? throw new ArgumentNullException(nameof(addProductCommandHandler));
        _getProductQueryHandler = getProductQueryHandler ?? throw new ArgumentNullException(nameof(getProductQueryHandler));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpPost]
    [Route("add-product")]
    public async Task<IActionResult> AddProductAsync([FromBody] AddProductRequest? request)
    {
        if(request == null)
        {
            return BadRequest("Request is null");
        }
        await _addProductCommandHandler.HandleAsync(new AddProductCommand(request.Name, request.Price,
            request.Description, request.PictureUrl));
        return Ok();
    }
    
    [HttpGet]
    [Route("get-product/{id}")]
    public async Task<IActionResult> GetProductById([FromRoute] int id)
    { 
        var product = await _getProductQueryHandler.HandleAsync(new GetProductQuery(id));
        if (product == null)
        { 
            return NotFound("Product not found");
        }
        
        var mappedProduct = _mapper.Map<ProductResponse>(product);
        return Ok(mappedProduct);
    }

}
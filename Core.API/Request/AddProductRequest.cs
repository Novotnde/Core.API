using System.ComponentModel.DataAnnotations;

namespace Core.API.Request;

public class AddProductRequest
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    public decimal Price { get; set; }
    
    [Required]
    public string PictureUrl { get; set; }
}
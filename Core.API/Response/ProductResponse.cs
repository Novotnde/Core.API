using System.ComponentModel.DataAnnotations;

namespace Core.API.Response;

public class ProductResponse
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    public decimal Price { get; set; }
    
    [Required]
    public string ImageUrl { get; set; }
}


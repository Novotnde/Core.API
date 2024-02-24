namespace Core.DataAccess.Entities;

public class ProductEntity
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }

    public string PictureUrl { get; set; }
}
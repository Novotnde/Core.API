using Core.Commands.Contracts.Base;

namespace Core.Commands.Command;

public class AddProductCommand : ICommand
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }

    public string PictureUrl { get; set; }
    
    public AddProductCommand(string name, decimal price, string description, string pictureUrl)
    {
        Name = name;
        Price = price;
        Description = description;
        PictureUrl = pictureUrl;
    }
}
using Core.Commands.Command;
using Core.Commands.Contracts.Base;

namespace Core.Commands.Contracts;

public interface IAddProductCommandHandler : ICommandHandler<AddProductCommand>
{ 
    Task HandleAsync(AddProductCommand command);
}
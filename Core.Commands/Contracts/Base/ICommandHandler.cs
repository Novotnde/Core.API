namespace Core.Commands.Contracts.Base;

public interface ICommandHandler<TCommand> where TCommand : ICommand
{
    protected Task HandleAsync(TCommand command);
}
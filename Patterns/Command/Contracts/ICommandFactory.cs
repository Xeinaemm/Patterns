namespace Patterns.Command.Contracts
{
	public interface ICommandFactory
	{
		string CommandName { get; }
		string Description { get; }
		ICommand MakeCommand(string[] arguments);
	}
}
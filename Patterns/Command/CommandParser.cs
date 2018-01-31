using System.Collections.Generic;
using System.Linq;
using Patterns.Command.Contracts;
using Patterns.Command.Implementation;

namespace Patterns.Command
{
	public class CommandParser
	{
		private readonly IEnumerable<ICommandFactory> _availableCommands;

		public CommandParser(IEnumerable<ICommandFactory> availableCommands) => _availableCommands = availableCommands;

		public ICommand ParseCommand(string[] args)
		{
			var requestedCommandName = args[0];
			var command = FindRequestedCommand(requestedCommandName);

			return null == command
				? new NotFoundCommand {Name = requestedCommandName}
				: command.MakeCommand(args);
		}

		private ICommandFactory FindRequestedCommand(string requestedCommandName)
		{
			return _availableCommands
				.FirstOrDefault(x => x.CommandName == requestedCommandName);
		}
	}
}
using System;
using Patterns.Command.Contracts;

namespace Patterns.Command.Implementation
{
	public class UpdateQuantityCommand : ICommand, ICommandFactory
	{
		public int NewQuantity { get; set; }

		public void Execute()
		{
			const int oldQuantity = 5;
			Console.WriteLine("DATABASE: Updated");
			Console.WriteLine($"LOG: Updated order quantity from {oldQuantity} to {NewQuantity}");
		}

		public string CommandName => "UpdateQuantity";

		public string Description => "UpdateQuantity number";

		public ICommand MakeCommand(string[] arguments) => new UpdateQuantityCommand {NewQuantity = int.Parse(arguments[1])};
	}
}
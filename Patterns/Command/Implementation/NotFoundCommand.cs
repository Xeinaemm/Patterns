using System;
using Patterns.Command.Contracts;

namespace Patterns.Command.Implementation
{
	public class NotFoundCommand : ICommand
	{
		public string Name { get; set; }

		public void Execute()
		{
			Console.WriteLine($"Couldn't find command: {Name}");
		}
	}
}
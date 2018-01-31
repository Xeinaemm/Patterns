using System.Collections.Generic;
using AutoFixture.Xunit2;
using Patterns.Command;
using Patterns.Command.Contracts;
using Patterns.Command.Implementation;
using Patterns.Tests.Helpers;
using Xunit;

namespace Patterns.Tests
{
	public class CommandShould
	{
		[Theory]
		[InlineAutoData(new[] {"test", "65"}, 65, true)]
		[InlineAutoData(new[] {"test", "44"}, 4, false)]
		public void UpdateQuantity(string[] command, int expectedQuantity, bool expected, UpdateQuantityCommand sut)
		{
			var setup = sut.MakeCommand(command) as UpdateQuantityCommand;
			var actual = expectedQuantity.Equals(setup?.NewQuantity);
			Assert.Equal(expected, actual);
		}

		[Theory]
		[AutoMoqData]
		public void BeAssignableFromICommand(UpdateQuantityCommand sut)
		{
			Assert.IsAssignableFrom<ICommand>(sut);
		}

		[Theory]
		[AutoMoqData]
		public void BeAssignableFromICommandFactory(UpdateQuantityCommand sut)
		{
			Assert.IsAssignableFrom<ICommandFactory>(sut);
		}

		[Theory]
		[AutoMoqData]
		public void ReturnNotNullCommandWhenCommandDoesntExists(string[] command, IEnumerable<ICommandFactory> dummy)
		{
			var sut = new CommandParser(dummy);
			var actual = sut.ParseCommand(command);
			Assert.NotNull(actual);
		}
	}
}
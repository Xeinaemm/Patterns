using System.Collections.Generic;
using Patterns.Builder;
using Patterns.Builder.ConcreteBuilders;
using Patterns.Tests.Resemblances;
using Xunit;

namespace Patterns.Tests
{
	public class BuilderShould
	{
		[Fact]
		public void CreateStandardSandwich()
		{
			var sut = new SandwichDirector(new StandardSandwichBuilder());
			sut.BuildSandwich();
			var actual = sut.GetSandwich();

			var expected = new SandwichResemblance
			{
				HasMayo = false,
				HasMustard = true,
				Vegetables = new List<string> {"Tomato", "Onion"},
				CheeseType = CheeseType.Cheddar,
				MeatType = MeatType.Turkey,
				BreadType = BreadType.White,
				IsToasted = true
			};
			Assert.True(expected.Equals(actual));
		}
	}
}
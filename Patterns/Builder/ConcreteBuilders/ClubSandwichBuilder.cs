using System.Collections.Generic;

namespace Patterns.Builder.ConcreteBuilders
{
	public class ClubSandwichBuilder : SandwichBuilder
	{
		public override void AddCondiments()
		{
			_sandwich.HasMayo = true;
			_sandwich.HasMustard = true;
		}

		public override void ApplyVegetables()
		{
			_sandwich.Vegetables = new List<string> {"Tomato", "Onion", "Lettuce"};
		}

		public override void ApplyMeatAndCheese()
		{
			_sandwich.CheeseType = CheeseType.Swiss;
			_sandwich.MeatType = MeatType.Turkey;
		}

		public override void PrepareBread()
		{
			_sandwich.BreadType = BreadType.White;
			_sandwich.IsToasted = true;
		}
	}
}
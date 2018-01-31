using System.Collections.Generic;

namespace Patterns.Builder.ConcreteBuilders
{
	public class StandardSandwichBuilder : SandwichBuilder
	{
		public override void AddCondiments()
		{
			_sandwich.HasMayo = false;
			_sandwich.HasMustard = true;
		}

		public override void ApplyVegetables()
		{
			_sandwich.Vegetables = new List<string> {"Tomato", "Onion"};
		}

		public override void ApplyMeatAndCheese()
		{
			_sandwich.CheeseType = CheeseType.Cheddar;
			_sandwich.MeatType = MeatType.Turkey;
		}

		public override void PrepareBread()
		{
			_sandwich.BreadType = BreadType.White;
			_sandwich.IsToasted = true;
		}
	}
}
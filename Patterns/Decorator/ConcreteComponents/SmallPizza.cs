using Patterns.Decorator.Component;

namespace Patterns.Decorator.ConcreteComponents
{
	public class SmallPizza : IPizza
	{
		public SmallPizza() => Description = "Small Pizza";

		public string Description { get; set; }

		public string GetDescription() => Description;

		public double CalculateCost() => 3.00;
	}
}
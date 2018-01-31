using Patterns.Decorator.Component;

namespace Patterns.Decorator.ConcreteComponents
{
	public class LargePizza : IPizza
	{
		public LargePizza() => Description = "Large Pizza";

		public string Description { get; set; }

		public string GetDescription() => Description;

		public double CalculateCost() => 9.00;
	}
}
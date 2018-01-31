using Patterns.Decorator.Component;

namespace Patterns.Decorator.ConcreteComponents
{
	public class MediumPizza : IPizza
	{
		public MediumPizza() => Description = "Medium Pizza";

		public string Description { get; set; }

		public string GetDescription() => Description;

		public double CalculateCost() => 6.00;
	}
}
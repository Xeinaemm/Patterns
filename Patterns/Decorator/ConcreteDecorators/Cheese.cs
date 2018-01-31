using Patterns.Decorator.Component;
using Patterns.Decorator.Decorator;

namespace Patterns.Decorator.ConcreteDecorators
{
	public class Cheese : PizzaDecorator
	{
		public Cheese(IPizza pizza) : base(pizza) => Description = "Cheese";

		public override string GetDescription() =>
			$"{_pizza.GetDescription()}, {Description}";

		public override double CalculateCost() =>
			_pizza.CalculateCost() + 1.25;
	}
}
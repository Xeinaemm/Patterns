using Patterns.Decorator.Component;
using Patterns.Decorator.Decorator;

namespace Patterns.Decorator.ConcreteDecorators
{
	public class Ham : PizzaDecorator
	{
		public Ham(IPizza pizza) : base(pizza) => Description = "Ham";

		public override string GetDescription() =>
			$"{_pizza.GetDescription()}, {Description}";

		public override double CalculateCost() =>
			_pizza.CalculateCost() + 1.00;
	}
}
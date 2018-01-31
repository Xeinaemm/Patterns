using Patterns.Decorator.Component;
using Patterns.Decorator.Decorator;

namespace Patterns.Decorator.ConcreteDecorators
{
	public class Peppers : PizzaDecorator
	{
		public Peppers(IPizza pizza) : base(pizza) => Description = "Peppers";

		public override string GetDescription() =>
			$"{_pizza.GetDescription()}, {Description}";

		public override double CalculateCost() =>
			_pizza.CalculateCost() + 2.00;
	}
}
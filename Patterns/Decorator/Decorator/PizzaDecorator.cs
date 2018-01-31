using Patterns.Decorator.Component;

namespace Patterns.Decorator.Decorator
{
	public class PizzaDecorator : IPizza
	{
		protected readonly IPizza _pizza;

		protected PizzaDecorator(IPizza pizza) => _pizza = pizza;

		public string Description { get; set; }

		public virtual string GetDescription() => _pizza.Description;

		public virtual double CalculateCost() => _pizza.CalculateCost();
	}
}
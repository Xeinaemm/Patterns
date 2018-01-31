using Patterns.Strategy.Contracts;
using Patterns.Strategy.Models;

namespace Patterns.Strategy.Implementation.Services
{
	public class ShippingCostCalculatorService
	{
		private readonly IShippingCostStrategy _shippingCostStrategy;

		public ShippingCostCalculatorService(IShippingCostStrategy shippingCostStrategy) =>
			_shippingCostStrategy = shippingCostStrategy;

		public double CalculateShippingCost(Order order) => _shippingCostStrategy.Calculate(order);
	}
}
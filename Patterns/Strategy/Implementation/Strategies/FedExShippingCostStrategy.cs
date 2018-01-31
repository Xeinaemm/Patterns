using Patterns.Strategy.Contracts;
using Patterns.Strategy.Models;

namespace Patterns.Strategy.Implementation.Strategies
{
	public class FedExShippingCostStrategy : IShippingCostStrategy
	{
		public double Calculate(Order order) => 5.00d;
	}
}
using Patterns.Strategy.Contracts;
using Patterns.Strategy.Models;

namespace Patterns.Strategy.Implementation.Strategies
{
	public class UPSShippingCostStrategy : IShippingCostStrategy
	{
		public double Calculate(Order order) => 4.25d;
	}
}
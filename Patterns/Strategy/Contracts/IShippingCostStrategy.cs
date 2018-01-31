using Patterns.Strategy.Models;

namespace Patterns.Strategy.Contracts
{
	public interface IShippingCostStrategy
	{
		double Calculate(Order order);
	}
}
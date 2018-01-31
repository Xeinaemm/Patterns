using Patterns.Rules.Contracts;
using Patterns.Rules.Models;

namespace Patterns.Rules.Rules
{
	public class FirstTimeCustomerRule : IRule
	{
		public decimal CalculateCustomerDiscount(Customer customer) => !customer.DateOfFirstPurchase.HasValue ? 0.15m : 0;
	}
}
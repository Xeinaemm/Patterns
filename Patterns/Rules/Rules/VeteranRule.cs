using Patterns.Rules.Contracts;
using Patterns.Rules.Models;

namespace Patterns.Rules.Rules
{
	public class VeteranRule : IRule
	{
		public decimal CalculateCustomerDiscount(Customer customer) => customer.IsVeteran ? 0.1m : 0;
	}
}
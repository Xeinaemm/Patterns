using Patterns.Rules.Models;

namespace Patterns.Rules.Contracts
{
	public interface IRule
	{
		decimal CalculateCustomerDiscount(Customer customer);
	}
}
using System.Collections.Generic;
using System.Linq;
using Patterns.Rules.Contracts;
using Patterns.Rules.Models;
using Patterns.Rules.Rules;

namespace Patterns.Rules
{
	public class DiscountCalculator
	{
		private readonly IList<IRule> _rules = new List<IRule>();

		public DiscountCalculator()
		{
			_rules.Add(new BirthdayDiscountRule());
			_rules.Add(new SeniorRule());
			_rules.Add(new VeteranRule());
			_rules.Add(new LoyalCustomerRule(1, 0.10m));
			_rules.Add(new LoyalCustomerRule(5, 0.12m));
			_rules.Add(new LoyalCustomerRule(10, 0.20m));
			_rules.Add(new FirstTimeCustomerRule());
		}

		public decimal CalculateDiscountPercentage(Customer customer)
		{
			return _rules.Select(rule => rule.CalculateCustomerDiscount(customer))
				.Concat(new decimal[] {0})
				.Max();
		}
	}
}
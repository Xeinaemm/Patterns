using System;
using Patterns.Rules.Contracts;
using Patterns.Rules.Models;

namespace Patterns.Rules.Rules
{
	public class LoyalCustomerRule : IRule
	{
		private readonly decimal _discount;
		private readonly int _yearsAsCustomer;

		public LoyalCustomerRule(int yearsAsCustomer, decimal discount)
		{
			_yearsAsCustomer = yearsAsCustomer;
			_discount = discount;
		}

		public decimal CalculateCustomerDiscount(Customer customer)
		{
			if (!customer.DateOfFirstPurchase.HasValue) return 0;
			if (customer.DateOfFirstPurchase.Value.AddYears(_yearsAsCustomer) > DateTime.Today) return 0;
			var birthdayRule = new BirthdayDiscountRule();

			return _discount + birthdayRule.CalculateCustomerDiscount(customer);
		}
	}
}
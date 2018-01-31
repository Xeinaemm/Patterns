using System;
using Patterns.Rules.Contracts;
using Patterns.Rules.Models;

namespace Patterns.Rules.Rules
{
	public class BirthdayDiscountRule : IRule
	{
		public decimal CalculateCustomerDiscount(Customer customer)
		{
			if (customer.DateOfBirth != null && customer.DateOfBirth.Value.Month == DateTime.Today.Month &&
				customer.DateOfBirth.Value.Day == DateTime.Today.Day)
				return 0.10m;
			return 0;
		}
	}
}
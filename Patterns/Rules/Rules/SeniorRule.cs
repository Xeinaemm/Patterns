using System;
using Patterns.Rules.Contracts;
using Patterns.Rules.Models;

namespace Patterns.Rules.Rules
{
	public class SeniorRule : IRule
	{
		public decimal CalculateCustomerDiscount(Customer customer) =>
			customer.DateOfBirth < DateTime.Now.AddYears(-65) ? .05m : 0;
	}
}
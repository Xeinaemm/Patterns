using System;
using Patterns.Visitor.Implementation;
using Patterns.Visitor.Models;

namespace Patterns.Visitor
{
	public class Util
	{
		public void JustUtil()
		{
			var person = new Person();
			person.Assets.Add(new BankAccount {Amount = 1000, MonthlyInterest = 0.01});
			person.Assets.Add(new BankAccount {Amount = 2000, MonthlyInterest = 0.02});
			person.Assets.Add(new RealEstate {EstimatedValue = 79000, MonthlyRent = 500});
			person.Assets.Add(new Loan {Owed = 40000, MonthlyPayment = 40});

			var netWorthVisitor = new NetWorthVisitor();
			var incomeVisitor = new IncomeVisitor();

			person.Accept(netWorthVisitor);
			person.Accept(incomeVisitor);

			Console.WriteLine(netWorthVisitor.Total);
			Console.WriteLine(incomeVisitor.Amount);
		}
	}
}
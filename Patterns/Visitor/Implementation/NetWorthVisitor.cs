using Patterns.Visitor.Contracts;
using Patterns.Visitor.Models;

namespace Patterns.Visitor.Implementation
{
	public class NetWorthVisitor : IVisitor
	{
		public int Total { get; set; }

		public void Visit(RealEstate realEstate)
		{
			Total += realEstate.EstimatedValue;
		}

		public void Visit(BankAccount bankAccount)
		{
			Total += bankAccount.Amount;
		}

		public void Visit(Loan loan)
		{
			Total -= loan.Owed;
		}
	}
}
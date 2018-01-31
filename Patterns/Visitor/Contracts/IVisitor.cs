using Patterns.Visitor.Models;

namespace Patterns.Visitor.Contracts
{
	public interface IVisitor
	{
		void Visit(RealEstate realEstate);
		void Visit(BankAccount bankAccount);
		void Visit(Loan loan);
	}
}
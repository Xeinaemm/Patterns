using Patterns.ChainOfResponsibility.Enums;

namespace Patterns.ChainOfResponsibility.Contracts
{
	public interface IExpenseHandler
	{
		ApprovalResponse Approve(IExpenseReport expenseReport);
		void RegisterNext(IExpenseHandler next);
	}
}
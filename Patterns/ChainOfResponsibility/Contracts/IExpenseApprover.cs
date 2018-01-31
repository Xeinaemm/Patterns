using Patterns.ChainOfResponsibility.Enums;

namespace Patterns.ChainOfResponsibility.Contracts
{
	public interface IExpenseApprover
	{
		ApprovalResponse ApproveExpense(IExpenseReport expenseReport);
	}
}
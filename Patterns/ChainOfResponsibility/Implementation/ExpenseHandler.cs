using Patterns.ChainOfResponsibility.Contracts;
using Patterns.ChainOfResponsibility.Enums;

namespace Patterns.ChainOfResponsibility.Implementation
{
	public class ExpenseHandler : IExpenseHandler
	{
		private readonly IExpenseApprover _expenseApprover;
		private IExpenseHandler _expenseHandler;

		public ExpenseHandler(IExpenseApprover expenseApprover)
		{
			_expenseApprover = expenseApprover;
			_expenseHandler = EndOfChainExpenseHandler.Instance;
		}

		public ApprovalResponse Approve(IExpenseReport expenseReport)
		{
			var response = _expenseApprover.ApproveExpense(expenseReport);
			return response == ApprovalResponse.BeyondApprovalLimit
				? _expenseHandler.Approve(expenseReport)
				: response;
		}

		public void RegisterNext(IExpenseHandler next)
		{
			_expenseHandler = next;
		}
	}
}
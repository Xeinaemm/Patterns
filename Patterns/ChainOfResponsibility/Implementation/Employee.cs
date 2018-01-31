using Patterns.ChainOfResponsibility.Contracts;
using Patterns.ChainOfResponsibility.Enums;

namespace Patterns.ChainOfResponsibility.Implementation
{
	public class Employee : IExpenseApprover
	{
		private readonly decimal _approvalLimit;

		public Employee(string name, decimal approvalLimit)
		{
			Name = name;
			_approvalLimit = approvalLimit;
		}

		public string Name { get; }

		public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
			=> expenseReport.Total > _approvalLimit
				? ApprovalResponse.BeyondApprovalLimit
				: ApprovalResponse.Approved;
	}
}
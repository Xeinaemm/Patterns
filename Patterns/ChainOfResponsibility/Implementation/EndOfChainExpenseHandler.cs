using System;
using Patterns.ChainOfResponsibility.Contracts;
using Patterns.ChainOfResponsibility.Enums;

namespace Patterns.ChainOfResponsibility.Implementation
{
	public class EndOfChainExpenseHandler : IExpenseHandler
	{
		private EndOfChainExpenseHandler()
		{
		}

		public static EndOfChainExpenseHandler Instance { get; } = new EndOfChainExpenseHandler();

		public ApprovalResponse Approve(IExpenseReport expenseReport)
			=> ApprovalResponse.Denied;

		public void RegisterNext(IExpenseHandler next)
		{
			throw new InvalidOperationException();
		}
	}
}
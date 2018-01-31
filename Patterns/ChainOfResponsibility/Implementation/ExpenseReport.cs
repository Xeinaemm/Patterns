using Patterns.ChainOfResponsibility.Contracts;

namespace Patterns.ChainOfResponsibility.Implementation
{
	public class ExpenseReport : IExpenseReport
	{
		public ExpenseReport(decimal total) => Total = total;
		public decimal Total { get; }
	}
}
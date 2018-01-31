using Patterns.ChainOfResponsibility.Enums;
using Patterns.ChainOfResponsibility.Implementation;
using Xunit;

namespace Patterns.Tests
{
	public class ChainOfResponsibilityShould
	{
		[Theory]
		[InlineData(0, ApprovalResponse.Approved)]
		[InlineData(1000, ApprovalResponse.Approved)]
		[InlineData(5000, ApprovalResponse.Approved)]
		[InlineData(20000, ApprovalResponse.Approved)]
		[InlineData(20001, ApprovalResponse.Denied)]
		public void ApproveCorrect(int valueToApprove, ApprovalResponse expected)
		{
			var william = new ExpenseHandler(new Employee("William Worker", new decimal(0)));
			var mary = new ExpenseHandler(new Employee("Mary Manager", new decimal(1000)));
			var victor = new ExpenseHandler(new Employee("Victor Vicepres", new decimal(5000)));
			var paula = new ExpenseHandler(new Employee("Paula President", new decimal(20000)));

			william.RegisterNext(mary);
			mary.RegisterNext(victor);
			victor.RegisterNext(paula);

			var expense = new ExpenseReport(valueToApprove);
			var actual = william.Approve(expense);

			Assert.Equal(expected, actual);
		}
	}
}
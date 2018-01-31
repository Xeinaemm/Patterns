using Patterns.Visitor.Contracts;

namespace Patterns.Visitor.Models
{
	public class Loan : IAsset
	{
		public int Owed { get; set; }
		public int MonthlyPayment { get; set; }

		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
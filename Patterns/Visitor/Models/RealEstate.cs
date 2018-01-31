using Patterns.Visitor.Contracts;

namespace Patterns.Visitor.Models
{
	public class RealEstate : IAsset
	{
		public int EstimatedValue { get; set; }
		public int MonthlyRent { get; set; }

		public void Accept(IVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
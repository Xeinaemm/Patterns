namespace Patterns.EventAggregator.Model
{
	public class Order
	{
		public Order() => OrderID = NewID++;

		public static int NewID { get; private set; } = 1;

		public int OrderID { get; }
		public string OrderNumber { get; set; }
		public string Description { get; set; }
	}
}
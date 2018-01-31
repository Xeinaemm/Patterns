using System.Collections.Generic;

namespace Patterns.LazyLoading.Ghosts
{
	public class OrderItemRepository
	{
		public static IEnumerable<OrderItem> ListForOrder(int orderId) => new List<OrderItem>
		{
			new OrderItem(),
			new OrderItem(),
			new OrderItem()
		};
	}
}
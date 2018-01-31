using System.Collections.Generic;
using Patterns.LazyLoading.ValueHolder.Contracts;

namespace Patterns.LazyLoading.ValueHolder.Implementation
{
	public class OrderItemLoader : IValueLoader<IList<OrderItem>>
	{
		private int _orderId;

		public OrderItemLoader(int orderId) => _orderId = orderId;

		public IList<OrderItem> Load() => new List<OrderItem>();
	}
}
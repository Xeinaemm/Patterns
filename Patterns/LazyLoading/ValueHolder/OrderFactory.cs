using System.Collections.Generic;
using Patterns.LazyLoading.ValueHolder.Implementation;
using Patterns.LazyLoading.ValueHolder.Model;

namespace Patterns.LazyLoading.ValueHolder
{
	public class OrderFactory
	{
		public OrderValueHolder Create(int id)
		{
			var order = new OrderValueHolder(id);
			order.SetItems(new ValueHolder<IList<OrderItem>>(new OrderItemLoader(id)));
			return order;
		}
	}
}
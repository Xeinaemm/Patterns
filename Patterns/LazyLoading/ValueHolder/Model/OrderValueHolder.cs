using System.Collections.Generic;

namespace Patterns.LazyLoading.ValueHolder.Model
{
	public class OrderValueHolder
	{
		private ValueHolder<IList<OrderItem>> _items;

		public OrderValueHolder(int id) => Id = id;

		public int Id { get; set; }

		public IList<OrderItem> Items => _items.Value;

		public void SetItems(ValueHolder<IList<OrderItem>> valueHolder)
		{
			_items = valueHolder;
		}
	}
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Patterns.EventAggregator.Contracts;
using Patterns.EventAggregator.Model;

// ReSharper disable UnusedMember.Local

namespace Patterns.EventAggregator.Util
{
	public class Publisher
	{
		private readonly IEventAggregator _eventAggregator;
		private readonly IList<Order> _orders;

		public Publisher()
		{
			_orders = new ObservableCollection<Order>();
			_eventAggregator = new Implementation.EventAggregator();
		}

		private void Publish()
		{
			var order = new Order {Description = "New Order", OrderNumber = "New " + Order.NewID};
			_orders.Add(order);
			_eventAggregator.Publish(new OrderSelected {Order = order});
		}
	}
}
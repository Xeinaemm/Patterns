using Patterns.EventAggregator.Contracts;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Util
{
	public class Subscriber : ISubscriber<OrderSelected>, ISubscriber<OrderSaved>
	{
		public Subscriber(IEventAggregator eventAggregator)
		{
			eventAggregator.Subscribe(this);
		}

		public void OnEvent(OrderSaved e)
		{
			// util saved order
		}

		public void OnEvent(OrderSelected e)
		{
			//util selected order
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Patterns.EventAggregator.Contracts;

namespace Patterns.EventAggregator.Implementation
{
	public class EventAggregator : IEventAggregator
	{
		private readonly IDictionary<Type, IList<WeakReference>> _eventSubscriberLists =
			new Dictionary<Type, IList<WeakReference>>();

		private readonly object _lock = new object();

		public void Subscribe(object subscriber)
		{
			lock (_lock)
			{
				var subscriberTypes =
					subscriber.GetType()
						.GetInterfaces()
						.Where(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ISubscriber<>));
				var weakReference = new WeakReference(subscriber);

				foreach (var subscriberType in subscriberTypes)
				{
					var subscribers = GetSubscribers(subscriberType);
					subscribers.Add(weakReference);
				}
			}
		}

		public void Publish<TEvent>(TEvent eventToPublish)
		{
			var subscriberType = typeof(ISubscriber<>).MakeGenericType(typeof(TEvent));
			var subscribers = GetSubscribers(subscriberType);

			var subscribersToRemove = new List<WeakReference>();

			foreach (var weakSubscriber in subscribers)
				if (weakSubscriber.IsAlive)
				{
					var subscriber = (ISubscriber<TEvent>) weakSubscriber.Target;
					var syncContext = SynchronizationContext.Current ?? new SynchronizationContext();
					syncContext.Post(x => subscriber.OnEvent(eventToPublish), null);
				}
				else
				{
					subscribersToRemove.Add(weakSubscriber);
				}

			if (!subscribersToRemove.Any()) return;
			lock (_lock)
				foreach (var weakReference in subscribersToRemove)
					subscribers.Remove(weakReference);
		}

		private IList<WeakReference> GetSubscribers(Type subscriberType)
		{
			IList<WeakReference> subscribers;
			lock (_lock)
			{
				var found = _eventSubscriberLists.TryGetValue(subscriberType, out subscribers);
				if (found) return subscribers;
				subscribers = new List<WeakReference>();
				_eventSubscriberLists.Add(subscriberType, subscribers);
			}

			return subscribers;
		}
	}
}
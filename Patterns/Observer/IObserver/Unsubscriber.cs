using System;
using System.Collections.Generic;

namespace Patterns.Observer.IObserver
{
	public class Unsubscriber : IDisposable
	{
		private readonly IObserver<Stock> _observer;
		private readonly IList<IObserver<Stock>> _observers;

		public Unsubscriber(IList<IObserver<Stock>> observers, IObserver<Stock> observer)
		{
			_observers = observers;
			_observer = observer;
		}

		public void Dispose()
		{
			if (_observer != null && _observers.Contains(_observer)) _observers.Remove(_observer);
		}
	}
}
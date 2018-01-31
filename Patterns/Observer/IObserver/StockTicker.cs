using System;
using System.Collections.Generic;

namespace Patterns.Observer.IObserver
{
	public class StockTicker : IObservable<Stock>
	{
		private readonly IList<IObserver<Stock>> observers = new List<IObserver<Stock>>();

		private Stock stock;

		public Stock Stock
		{
			get => stock;
			set
			{
				stock = value;
				Notify(stock);
			}
		}

		public IDisposable Subscribe(IObserver<Stock> observer)
		{
			if (!observers.Contains(observer))
				observers.Add(observer);
			return new Unsubscriber(observers, observer);
		}

		private void Notify(Stock s)
		{
			foreach (var observer in observers)
				if (s.Symbol == null || s.Price < 0)
					observer.OnError(new Exception("Bad Stock Data"));
				else
					observer.OnNext(s);
		}
	}
}
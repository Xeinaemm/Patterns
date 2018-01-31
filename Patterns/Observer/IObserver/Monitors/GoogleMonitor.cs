using System;

namespace Patterns.Observer.IObserver.Monitors
{
	public class GoogleMonitor : IObserver<Stock>
	{
		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(Stock value)
		{
			if (value.Symbol == "GOOG")
				Console.WriteLine($"Google's new price is: {value.Price}");
		}
	}
}
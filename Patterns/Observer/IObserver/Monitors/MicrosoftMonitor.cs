using System;

namespace Patterns.Observer.IObserver.Monitors
{
	public class MicrosoftMonitor : IObserver<Stock>
	{
		public void OnCompleted()
		{
		}

		public void OnError(Exception error)
		{
		}

		public void OnNext(Stock value)
		{
			if (value.Symbol == "MSFT" && value.Price > 10.00m)
				Console.WriteLine($"Microsoft has reached the target price: {value.Price}");
		}
	}
}
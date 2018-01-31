using Patterns.Observer.GOF.Implementation;

// ReSharper disable UnusedVariable

namespace Patterns.Observer.GOF
{
	public class Util
	{
		public void JustUtil()
		{
			var stockTicker = new StockTicker();
			var goog = new GoogleObserver(stockTicker);
			var msft = new MicrosoftObserver(stockTicker);

			foreach (var s in SampleData.GetNext())
				stockTicker.Stock = s;
		}
	}
}
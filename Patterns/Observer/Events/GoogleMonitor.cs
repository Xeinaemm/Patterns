using System;

namespace Patterns.Observer.Events
{
	public class GoogleMonitor
	{
		public GoogleMonitor(StockTicker stockTicker) => stockTicker.StockChange += St_StockChange;

		private static void St_StockChange(object sender, StockChangeEventArgs e)
		{
			Check(e.Stock);
		}

		private static void Check(Stock value)
		{
			if (value.Symbol == "GOOG") Console.WriteLine($"Google's new price is: {value.Price}");
		}
	}
}
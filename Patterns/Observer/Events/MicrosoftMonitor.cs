using System;

namespace Patterns.Observer.Events
{
	public class MicrosoftMonitor
	{
		public MicrosoftMonitor(StockTicker stockTicker) => stockTicker.StockChange += St_StockChange;

		private static void St_StockChange(object sender, StockChangeEventArgs e)
		{
			Check(e.Stock);
		}

		private static void Check(Stock value)
		{
			if (value.Symbol == "MSFT" && value.Price > 10.00m)
				Console.WriteLine($"Microsoft has reached the target price: {value.Price}");
		}
	}
}
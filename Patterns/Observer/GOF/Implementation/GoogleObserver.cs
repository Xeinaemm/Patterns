using System;
using Patterns.Observer.GOF.Contracts;

namespace Patterns.Observer.GOF.Implementation
{
	public class GoogleObserver : IAbstractObserver
	{
		public GoogleObserver(StockTicker stockTicker)
		{
			StockTicker = stockTicker;
			stockTicker.Register(this);
		}

		public StockTicker StockTicker { get; }

		public void Update()
		{
			var price = StockTicker.Stock.Price;
			var symbol = StockTicker.Stock.Symbol;
			if (symbol == "GOOG") Console.WriteLine($"Google's new price is: {price}");
		}
	}
}
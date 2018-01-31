using System;
using Patterns.Observer.GOF.Contracts;

namespace Patterns.Observer.GOF.Implementation
{
	public class MicrosoftObserver : IAbstractObserver
	{
		public MicrosoftObserver(StockTicker stockTicker)
		{
			StockTicker = stockTicker;
			stockTicker.Register(this);
		}

		public StockTicker StockTicker { get; }

		public void Update()
		{
			var price = StockTicker.Stock.Price;
			var symbol = StockTicker.Stock.Symbol;
			if (symbol == "MSFT" && price > 10.00m)
				Console.WriteLine($"Microsoft has reached the target price: {price}");
		}
	}
}
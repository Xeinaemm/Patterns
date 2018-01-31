using System.Collections.Generic;
using System.Linq;

namespace Patterns.Observer
{
	public class SampleData
	{
		private static readonly decimal[] samplePrices = {10.00m, 10.25m, 555.55m, 9.50m, 9.03m, 500.00m, 499.99m, 10.10m};
		private static readonly string[] sampleStocks = {"MSFT", "MSFT", "GOOG", "MSFT", "MSFT", "GOOG", "GOOG", "MSFT"};

		public static IEnumerable<Stock> GetNext()
		{
			return samplePrices.Select((t, i) => new Stock
			{
				Symbol = sampleStocks[i],
				Price = t
			});
		}
	}
}
using Patterns.Observer.GOF.Contracts;

namespace Patterns.Observer.GOF
{
	public class StockTicker : AbstractSubject
	{
		private Stock _stock;

		public Stock Stock
		{
			get => _stock;
			set
			{
				_stock = value;
				Notify();
			}
		}
	}
}
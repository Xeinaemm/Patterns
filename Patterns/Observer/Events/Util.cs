// ReSharper disable UnusedVariable

namespace Patterns.Observer.Events
{
	public class Util
	{
		public void JustUtil()
		{
			var st = new StockTicker();

			var gf = new GoogleMonitor(st);
			var mf = new MicrosoftMonitor(st);

			foreach (var s in SampleData.GetNext())
				st.Stock = s;
		}
	}
}
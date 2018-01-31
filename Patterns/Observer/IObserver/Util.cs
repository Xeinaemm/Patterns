using Patterns.Observer.IObserver.Monitors;

namespace Patterns.Observer.IObserver
{
	public class Util
	{
		public void JustUtil()
		{
			var st = new StockTicker();

			var gf = new GoogleMonitor();
			var mf = new MicrosoftMonitor();

			using (st.Subscribe(gf))
			using (st.Subscribe(mf))
				foreach (var s in SampleData.GetNext())
					st.Stock = s;
		}
	}
}
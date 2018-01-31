namespace Patterns.Singleton
{
	public class ThreadSafeSingleton
	{
		private static readonly object _lock = new object();
		private static ThreadSafeSingleton _instance;

		private ThreadSafeSingleton()
		{
		}

		public static ThreadSafeSingleton Instance
		{
			get
			{
				lock (_lock) return _instance ?? (_instance = new ThreadSafeSingleton());
			}
		}
	}
}
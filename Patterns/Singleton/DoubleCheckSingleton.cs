namespace Patterns.Singleton
{
	public class DoubleCheckSingleton
	{
		private static DoubleCheckSingleton _instance;
		private static readonly object _lock = new object();


		private DoubleCheckSingleton()
		{
		}

		public static DoubleCheckSingleton Instance
		{
			get
			{
				if (_instance == null)
					lock (_lock)
						if (_instance == null)
							_instance = new DoubleCheckSingleton();
				return _instance;
			}
		}
	}
}
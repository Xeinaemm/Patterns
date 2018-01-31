namespace Patterns.Singleton
{
	public class LazySingleton
	{
		public static LazySingleton Instance => Nested.instance;

		private class Nested
		{
			internal static readonly LazySingleton instance = new LazySingleton();

			static Nested()
			{
			}
		}
	}
}
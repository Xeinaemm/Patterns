using Patterns.Flyweight.Contracts;

namespace Patterns.Flyweight.Implementation.Tiles
{
	public class StoneTile : ITile
	{
		private static int ObjectCounter;

		public StoneTile()
		{
			++ObjectCounter;
		}

		public string Print() => "Stone";

		public int Count() => ObjectCounter;
	}
}
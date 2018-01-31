using Patterns.Flyweight.Contracts;

namespace Patterns.Flyweight.Implementation.Tiles
{
	public class NullTile : ITile
	{
		public int Count() => 0;

		public string Print() => string.Empty;
	}
}
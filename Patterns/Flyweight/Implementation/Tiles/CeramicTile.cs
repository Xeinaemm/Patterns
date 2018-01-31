using Patterns.Flyweight.Contracts;

namespace Patterns.Flyweight.Implementation.Tiles
{
	public class CeramicTile : ITile
	{
		private static int _objectCounter;

		public CeramicTile()
		{
			++_objectCounter;
		}

		public string Print() => "Ceramic";

		public int Count() => _objectCounter;
	}
}
using System.Collections.Generic;
using Patterns.Flyweight.Contracts;
using Patterns.Flyweight.Implementation.Tiles;

namespace Patterns.Flyweight.Implementation
{
	public class TileFactory
	{
		private static readonly IDictionary<string, ITile> tiles =
			new Dictionary<string, ITile>();

		public virtual ITile GetTile(string tileType)
		{
			switch (tileType)
			{
				case "Ceramic":
					if (!tiles.ContainsKey("Ceramic"))
						tiles["Ceramic"] = new CeramicTile();
					return tiles["Ceramic"];
				case "Stone":
					if (!tiles.ContainsKey("Stone"))
						tiles["Stone"] = new StoneTile();
					return tiles["Stone"];
			}

			return new NullTile();
		}
	}
}
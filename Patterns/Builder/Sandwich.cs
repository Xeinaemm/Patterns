using System.Collections.Generic;

namespace Patterns.Builder
{
	public class Sandwich
	{
		public BreadType BreadType { get; set; }
		public bool IsToasted { get; set; }
		public CheeseType CheeseType { get; set; }
		public MeatType MeatType { get; set; }
		public bool HasMustard { get; set; }
		public bool HasMayo { get; set; }
		public IList<string> Vegetables { get; set; }
	}

	public enum MeatType
	{
		Turkey,
		Ham,
		Chicken,
		Salami
	}

	public enum CheeseType
	{
		American,
		Swiss,
		Cheddar,
		Provolone
	}

	public enum BreadType
	{
		White,
		Wheat
	}
}
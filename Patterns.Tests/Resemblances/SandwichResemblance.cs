using System.Linq;
using Patterns.Builder;

namespace Patterns.Tests.Resemblances
{
	public class SandwichResemblance : Sandwich
	{
		public override bool Equals(object obj)
		{
			if (obj is Sandwich sandwich)
				return Equals(BreadType, sandwich.BreadType) &&
						Equals(CheeseType, sandwich.CheeseType) &&
						Equals(HasMayo, sandwich.HasMayo) &&
						Equals(HasMustard, sandwich.HasMustard) &&
						Equals(IsToasted, sandwich.IsToasted) &&
						Equals(MeatType, sandwich.MeatType) &&
						Vegetables.SequenceEqual(sandwich.Vegetables);
			return base.Equals(obj);
		}

		public override int GetHashCode() => BreadType.GetHashCode() ^
											CheeseType.GetHashCode() ^
											HasMayo.GetHashCode() ^
											HasMustard.GetHashCode() ^
											IsToasted.GetHashCode() ^
											MeatType.GetHashCode() ^
											Vegetables.GetHashCode();
	}
}
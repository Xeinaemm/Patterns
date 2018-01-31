namespace Patterns.Builder
{
	public abstract class SandwichBuilder
	{
		protected Sandwich _sandwich;

		public void CreateNewSandwich()
		{
			_sandwich = new Sandwich();
		}

		public Sandwich GetSandwich() => _sandwich;
		public abstract void PrepareBread();
		public abstract void ApplyMeatAndCheese();
		public abstract void ApplyVegetables();
		public abstract void AddCondiments();
	}
}
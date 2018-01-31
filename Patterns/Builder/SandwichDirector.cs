namespace Patterns.Builder
{
	public class SandwichDirector
	{
		private readonly SandwichBuilder _builder;

		public SandwichDirector(SandwichBuilder builder) => _builder = builder;

		public void BuildSandwich()
		{
			_builder.CreateNewSandwich();
			_builder.PrepareBread();
			_builder.ApplyMeatAndCheese();
			_builder.ApplyVegetables();
			_builder.AddCondiments();
		}

		public Sandwich GetSandwich() => _builder.GetSandwich();
	}
}
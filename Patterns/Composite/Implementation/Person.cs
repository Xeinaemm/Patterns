using Patterns.Composite.Contracts;

namespace Patterns.Composite.Implementation
{
	public class Person : IParty
	{
		public string Name { get; set; }
		public int Gold { get; set; }
	}
}
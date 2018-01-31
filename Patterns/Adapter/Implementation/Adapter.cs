using Patterns.Adapter.Contract;

namespace Patterns.Adapter.Implementation
{
	public class Adapter : IClient
	{
		public int GetNumberOfItems() => Adaptee.GetList()
			.Count;
	}
}
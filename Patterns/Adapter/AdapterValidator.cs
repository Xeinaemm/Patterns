using Patterns.Adapter.Contract;

namespace Patterns.Adapter
{
	public class AdapterValidator
	{
		private readonly IClient _client;

		public AdapterValidator(IClient client) => _client = client;

		public int Count => _client.GetNumberOfItems();
	}
}
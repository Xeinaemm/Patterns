namespace Patterns.LazyLoading.VirtualProxy
{
	public class OrderFactory
	{
		public Order Create(int id) => new OrderProxy
		{
			Id = id
		};
	}
}
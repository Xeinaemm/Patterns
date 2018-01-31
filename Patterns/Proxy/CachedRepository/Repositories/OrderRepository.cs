using System;
using Patterns.Proxy.CachedRepository.Entities;

namespace Patterns.Proxy.CachedRepository.Repositories
{
	public class OrderRepository : Repository<OrderEntity>
	{
		public override OrderEntity Get(int id) => new OrderEntity
		{
			Id = id,
			CustomerId = 1,
			OrderDetails = new[] {1, 2, 2},
			OrderDate = DateTime.Now
		};
	}
}
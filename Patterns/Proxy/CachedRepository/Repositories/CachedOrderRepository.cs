using System.Runtime.Caching;
using Patterns.Proxy.CachedRepository.Entities;

namespace Patterns.Proxy.CachedRepository.Repositories
{
	public class CachedOrderRepository : OrderRepository
	{
		public override OrderEntity Get(int id)
		{
			var cacheKey = "OrderEntity-" + id;
			if (MemoryCache.Default[cacheKey] is OrderEntity entity) return entity;
			entity = base.Get(id);
			var cacheItem = new CacheItem(cacheKey, entity);
			var policy = new CacheItemPolicy();
			MemoryCache.Default.Add(cacheItem, policy);

			return entity;
		}
	}
}
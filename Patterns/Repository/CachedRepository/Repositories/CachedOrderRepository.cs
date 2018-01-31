using System.Runtime.Caching;
using Patterns.Repository.CachedRepository.Entities;

namespace Patterns.Repository.CachedRepository.Repositories
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
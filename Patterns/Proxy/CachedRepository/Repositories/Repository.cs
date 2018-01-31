namespace Patterns.Proxy.CachedRepository.Repositories
{
	public abstract class Repository<T>
	{
		public abstract T Get(int id);
	}
}
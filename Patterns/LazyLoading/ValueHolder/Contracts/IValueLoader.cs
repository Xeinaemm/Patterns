namespace Patterns.LazyLoading.ValueHolder.Contracts
{
	public interface IValueLoader<out T>
	{
		T Load();
	}
}
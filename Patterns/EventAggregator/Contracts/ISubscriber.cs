namespace Patterns.EventAggregator.Contracts
{
	public interface ISubscriber<in T>
	{
		void OnEvent(T e);
	}
}
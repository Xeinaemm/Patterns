namespace Patterns.EventAggregator.Contracts
{
	public interface IEventAggregator
	{
		void Subscribe(object subscriber);
		void Publish<TEvent>(TEvent eventToPublish);
	}
}
namespace Patterns.Facade.Contracts
{
	public interface IValueConverter<out TValue>
	{
		TValue Convert(object value);
	}
}
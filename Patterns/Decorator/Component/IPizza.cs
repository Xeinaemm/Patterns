namespace Patterns.Decorator.Component
{
	public interface IPizza
	{
		string Description { get; set; }
		string GetDescription();
		double CalculateCost();
	}
}
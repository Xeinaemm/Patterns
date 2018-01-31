namespace Patterns.Factory.Contracts
{
	public interface IAutoFactory
	{
		IAutomobile CreateSportCar();
		IAutomobile CreateLuxuryCar();
		IAutomobile CreateEconomyCar();
	}
}
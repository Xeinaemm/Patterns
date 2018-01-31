using Patterns.Facade.Models;

namespace Patterns.Facade.Contracts
{
	public interface ITemperatureFacade
	{
		LocalTemperature GetTemperature();
	}
}
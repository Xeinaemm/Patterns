using Patterns.Facade.Contracts;

namespace Patterns.Facade.Implementation.Services
{
	public class WeatherService : IWeatherService
	{
		public double GetTemperatureFarenheit() => 86.5;
	}
}
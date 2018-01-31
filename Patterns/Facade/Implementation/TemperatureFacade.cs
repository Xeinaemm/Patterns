using Patterns.Facade.Contracts;
using Patterns.Facade.Models;

namespace Patterns.Facade.Implementation
{
	public class TemperatureFacade : ITemperatureFacade
	{
		private readonly IValueConverter<double> _converter;
		private readonly IGeoLookupService _geoLookupService;
		private readonly IWeatherService _weatherService;

		public TemperatureFacade(IValueConverter<double> converter, IGeoLookupService geoLookupService,
			IWeatherService weatherService)
		{
			_converter = converter;
			_geoLookupService = geoLookupService;
			_weatherService = weatherService;
		}

		public LocalTemperature GetTemperature()
		{
			var city = _geoLookupService.GetCity();
			var state = _geoLookupService.GetState();

			var farenheit = _weatherService.GetTemperatureFarenheit();
			var celcius = _converter.Convert(farenheit);

			return new LocalTemperature
			{
				Farenheit = farenheit,
				Celcius = celcius,
				City = city,
				State = state
			};
		}
	}
}
using Patterns.Facade.Contracts;

namespace Patterns.Facade.Implementation.Services
{
	public class GeoLookupService : IGeoLookupService
	{
		public string GetCity() => "Gdansk";

		public string GetState() => "Pomeranian District";
	}
}
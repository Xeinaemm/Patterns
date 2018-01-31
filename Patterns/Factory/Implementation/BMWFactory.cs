using Patterns.Factory.Contracts;
using Patterns.Factory.Implementation.Autos.BMW;

namespace Patterns.Factory.Implementation
{
	public class BMWFactory : IAutoFactory
	{
		public IAutomobile CreateSportCar() => new BMWM3();

		public IAutomobile CreateLuxuryCar() => new BMW740i();

		public IAutomobile CreateEconomyCar() => new BMW328i();
	}
}
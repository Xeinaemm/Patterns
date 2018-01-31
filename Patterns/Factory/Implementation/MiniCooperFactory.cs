using Patterns.Factory.Contracts;
using Patterns.Factory.Implementation.Autos.Mini;

namespace Patterns.Factory.Implementation
{
	public class MiniCooperFactory : IAutoFactory
	{
		public IAutomobile CreateSportCar()
		{
			var mini = new MiniCooper();
			mini.AddSportPackage();
			return mini;
		}

		public IAutomobile CreateLuxuryCar()
		{
			var mini = new MiniCooper();
			mini.AddLuxuryPackage();
			return mini;
		}

		public IAutomobile CreateEconomyCar() => new MiniCooper();
	}
}
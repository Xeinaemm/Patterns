using Patterns.Factory.Contracts;

namespace Patterns.Factory.Implementation.Autos.Mini
{
	public class MiniCooper : IAutomobile
	{
		private string _name;

		public MiniCooper() => _name = "Mini Cooper";

		public string TurnOn() => _name;

		public void TurnOff()
		{
			//implementation
		}

		public void AddSportPackage()
		{
			_name += " S";
		}

		public void AddLuxuryPackage()
		{
			_name += " with leather upholstery";
		}
	}
}
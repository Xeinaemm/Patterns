using Patterns.Factory.Contracts;

namespace Patterns.Factory.Implementation.Autos.BMW
{
	public abstract class BMWBase : IAutomobile
	{
		public abstract string Name { get; }

		public string TurnOn() => Name;

		public void TurnOff()
		{
			//implementation
		}
	}
}
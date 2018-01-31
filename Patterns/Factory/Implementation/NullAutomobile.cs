using Patterns.Factory.Contracts;

namespace Patterns.Factory.Implementation
{
	public class NullAutomobile : IAutomobile
	{
		public string Name => string.Empty;

		public string TurnOn() => null;

		public void TurnOff()
		{
		}
	}
}
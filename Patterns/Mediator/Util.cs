using Patterns.Mediator.Implementation;
using Patterns.Mediator.Planes;

// ReSharper disable UnusedVariable

namespace Patterns.Mediator
{
	public class Util
	{
		public void JustUtil()
		{
			var atc = new AirTrafficControl();
			var plane1 = new Boeing737200("WS203", atc);
			var plane2 = new Airbus321("AC159", atc);
		}
	}
}
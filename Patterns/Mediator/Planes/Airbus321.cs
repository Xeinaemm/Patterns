using Patterns.Mediator.Contracts;

namespace Patterns.Mediator.Planes
{
	public class Airbus321 : Aircraft
	{
		public Airbus321(string callSign, IAirTrafficControl atc) : base(callSign, atc)
		{
		}

		public override int Ceiling => 25000;
	}
}
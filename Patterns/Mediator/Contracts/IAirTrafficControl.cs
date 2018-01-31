namespace Patterns.Mediator.Contracts
{
	public interface IAirTrafficControl
	{
		void ReceiveAircraftLocation(Aircraft aircarft);
		void RegisterAircraftUnderGuidance(Aircraft aircraft);
	}
}
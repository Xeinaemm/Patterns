using System;
using System.Collections.Generic;
using Patterns.Mediator.Contracts;

namespace Patterns.Mediator.Implementation
{
	public class AirTrafficControl : IAirTrafficControl
	{
		private readonly IList<Aircraft> _aircrafts = new List<Aircraft>();

		public void ReceiveAircraftLocation(Aircraft aircarft)
		{
			foreach (var plane in _aircrafts)
			{
				if (plane.Equals(aircarft)) continue;
				if (Math.Abs(plane.Altitude - aircarft.Altitude) >= 1000) continue;
				aircarft.Climb(1000);
				plane.WarnOfAirspaceIntrusionBy(aircarft);
			}
		}

		public void RegisterAircraftUnderGuidance(Aircraft aircraft)
		{
			if (!_aircrafts.Contains(aircraft)) _aircrafts.Add(aircraft);
		}
	}
}
namespace Patterns.Mediator.Contracts
{
	public abstract class Aircraft
	{
		private readonly IAirTrafficControl _atc;
		private int _altitude;

		protected Aircraft(string callSign, IAirTrafficControl atc)
		{
			_atc = atc;
			CallSign = callSign;
			_atc.RegisterAircraftUnderGuidance(this);
		}

		public abstract int Ceiling { get; }
		public string CallSign { get; }

		public int Altitude
		{
			get => _altitude;
			set
			{
				_altitude = value;
				_atc.ReceiveAircraftLocation(this);
			}
		}

		public void Climb(int heightoClimb)
		{
			Altitude += heightoClimb;
		}

		public override bool Equals(object obj)
		{
			if (obj?.GetType() != GetType()) return false;
			var incoming = obj as Aircraft;
			return CallSign.Equals(incoming?.CallSign);
		}

		public override int GetHashCode() => CallSign.GetHashCode();

		public void WarnOfAirspaceIntrusionBy(Aircraft aircraft)
		{
		}
	}
}
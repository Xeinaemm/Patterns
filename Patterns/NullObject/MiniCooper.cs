using System;

namespace Patterns.NullObject
{
	public class MiniCooper : AutomobileBase
	{
		public override Guid Id => Guid.NewGuid();

		public override string Name => "Mini Cooper S";

		public override void Start()
		{
			Console.WriteLine("Mini Cooper started. 1.6L of raw power is ready to go.");
		}

		public override void Stop()
		{
			Console.WriteLine("Mini Cooper stopped.");
		}
	}
}
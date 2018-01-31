using System;

namespace Patterns.NullObject
{
	public abstract class AutomobileBase
	{
		public abstract Guid Id { get; }
		public abstract string Name { get; }
		public static NullAutomobile NULL { get; } = new NullAutomobile();
		public abstract void Start();
		public abstract void Stop();
	}
}
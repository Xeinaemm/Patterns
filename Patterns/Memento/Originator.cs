using System;

namespace Patterns.Memento
{
	public class Originator
	{
		private object _state;

		public object State
		{
			get => _state;
			set
			{
				_state = value;
				Console.WriteLine("State = " + _state);
			}
		}

		public Memento CreateMemento() => new Memento(_state);

		public void SetMemento(Memento memento)
		{
			Console.WriteLine("Restoring state...");
			State = memento.State;
		}
	}
}
namespace Patterns.Memento
{
	public class Memento
	{
		public Memento(object state) => State = state;

		public object State { get; }
	}
}
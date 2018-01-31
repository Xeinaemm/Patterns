namespace Patterns.Memento
{
	public class Util
	{
		public void JustUtil()
		{
			var originator = new Originator {State = "On"};
			var caretaker = new Caretaker {Memento = originator.CreateMemento()};
			originator.State = "Off";
			originator.SetMemento(caretaker.Memento);
		}
	}
}
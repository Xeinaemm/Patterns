using System.Collections.Generic;

namespace Patterns.Observer.GOF.Contracts
{
	public abstract class AbstractSubject
	{
		private readonly IList<IAbstractObserver> observers = new List<IAbstractObserver>();

		public void Register(IAbstractObserver observer)
		{
			observers.Add(observer);
		}

		public void Unregister(IAbstractObserver observer)
		{
			observers.Remove(observer);
		}

		protected void Notify()
		{
			foreach (var abstractObserver in observers) abstractObserver.Update();
		}
	}
}
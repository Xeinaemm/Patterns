using System;
using Patterns.State.Contracts;
using Patterns.State.Implementation;

namespace Patterns.State.States
{
	public class Closed : BaseState, ICommands
	{
		private readonly WorkItem _owner;

		public Closed(WorkItem owner) => _owner = owner;

		public bool Delete() => true;

		public void Edit(string title, string desc)
		{
			_owner.Title = title;
			_owner.Description = desc;
		}

		public void Print()
		{
			Print(_owner);
		}

		public void SetState(string state)
		{
			switch (state)
			{
				case "closed":
					Console.WriteLine("Work Item is already closed.");
					break;
				case "resolved":
					_owner.State = state;
					break;
				default:
					Console.WriteLine("Work Item is in a closed state and cannot be set to {0}.", state);
					break;
			}
		}
	}
}
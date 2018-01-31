using System;
using Patterns.State.Contracts;
using Patterns.State.Implementation;

namespace Patterns.State.States
{
	public class Proposed : BaseState, ICommands
	{
		private readonly WorkItem owner;

		public Proposed(WorkItem owner) => this.owner = owner;

		public bool Delete() => true;

		public void Edit(string title, string desc)
		{
			owner.Title = title;
			owner.Description = desc;
		}

		public void Print()
		{
			Print(owner);
		}

		public void SetState(string state)
		{
			switch (state)
			{
				case "proposed":
					Console.WriteLine("Work Item is already proposed.");
					break;
				case "active":
					owner.State = state;
					break;
				default:
					Console.WriteLine("Work Item is in a proposed state and cannot be set to {0}.", state);
					break;
			}
		}
	}
}
using System;
using Patterns.State.Contracts;
using Patterns.State.Implementation;

namespace Patterns.State.States
{
	public class Resolved : BaseState, ICommands
	{
		private readonly WorkItem owner;

		public Resolved(WorkItem owner) => this.owner = owner;

		public bool Delete()
		{
			Console.WriteLine("Work Item is already resolved. Cannot Delete.");
			return false;
		}

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
				case "resolved":
					Console.WriteLine("Work Item is already resolved.");
					break;
				case "active":
				case "closed":
					owner.State = state;
					break;
				default:
					Console.WriteLine("Work Item is in an resolved state and cannot be set to {0}.", state);
					break;
			}
		}
	}
}
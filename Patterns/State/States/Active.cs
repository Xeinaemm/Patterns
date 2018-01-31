using System;
using Patterns.State.Contracts;
using Patterns.State.Implementation;

namespace Patterns.State.States
{
	public class Active : BaseState, ICommands
	{
		private readonly WorkItem _owner;

		public Active(WorkItem owner) => _owner = owner;

		public bool Delete()
		{
			Console.WriteLine("Work Item is already active. Cannot Delete.");
			return false;
		}

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
				case "active":
					Console.WriteLine("Work Item is already active.");
					break;
				case "proposed":
				case "resolved":
					_owner.State = state;
					break;
				default:
					Console.WriteLine("Work Item is in an active state and cannot be set to {0}.", state);
					break;
			}
		}
	}
}
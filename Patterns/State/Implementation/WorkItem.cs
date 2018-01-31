using Patterns.State.Contracts;
using Patterns.State.States;

namespace Patterns.State.Implementation
{
	public class WorkItem : IEntity, ICommands
	{
		private static IUnityOfWork unitOfWork;
		private string state;
		private ICommands stateCommands;

		public string State
		{
			get => state;
			set
			{
				state = value.ToLower();

				// Note that if we are dynamically loading the states, this needs to be changed
				switch (state)
				{
					case "proposed":
						stateCommands = new Proposed(this);
						break;
					case "active":
						stateCommands = new Active(this);
						break;
					case "resolved":
						stateCommands = new Resolved(this);
						break;
					case "closed":
						stateCommands = new Closed(this);
						break;
				}
			}
		}

		public string Title { get; set; }
		public string Description { get; set; }

		public bool Delete()
		{
			var canDelete = stateCommands.Delete();
			if (canDelete)
				unitOfWork.Entities.Remove(this);
			return canDelete;
		}

		public void Edit(string title, string desc)
		{
			stateCommands.Edit(title, desc);
		}

		public void Print()
		{
			stateCommands.Print();
		}

		public void SetState(string newState)
		{
			stateCommands.SetState(newState.ToLower());
		}

		public int Id { get; set; }

		internal static void Init(IUnityOfWork work)
		{
			unitOfWork = work;
		}

		internal static WorkItem Create()
		{
			var wi = new WorkItem
			{
				Id = -1,
				State = "Proposed"
			};
			unitOfWork.Entities.Add(wi);
			return wi;
		}

		internal static WorkItem FindById(int id) => (WorkItem) unitOfWork.Entities.Find(id);
	}
}
using System;
using Patterns.State.Contracts;
using Patterns.State.Implementation;

namespace Patterns.State
{
	public class Util
	{
		private static IUnityOfWork unitOfWork;

		public static void JustUtil(string[] args)
		{
			unitOfWork = new XmlUnityOfWork(@"./data.xml");
			WorkItem.Init(unitOfWork);

			string cmd, title = null, desc = null, state = null;
			int id;
			try
			{
				cmd = args[0]
					.ToLower();
				id = int.Parse(args[1]);
				if (args.Length > 2)
					title = args[2];
				if (args.Length > 3)
					desc = args[3];
				if (args.Length > 4)
					state = args[4];
			}
			catch (Exception)
			{
				PrintUsage();
				return;
			}

			var wi = WorkItem.FindById(id);

			try
			{
				switch (cmd)
				{
					case "create":
						wi = WorkItem.Create();
						wi.Edit(title, desc);
						wi.Print();
						break;
					case "delete":
						wi.Delete();
						break;
					case "edit":
						wi.Edit(title, desc);
						break;
					case "print":
						wi.Print();
						break;
					case "setstate":
						wi.SetState(state);
						break;
					default:
						PrintUsage();
						return;
				}

				unitOfWork.Commit();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Unable to perform operation. " + ex.Message);
				PrintUsage();
			}
		}

		private static void PrintUsage()
		{
			Console.WriteLine("Usage: state <command> <id> <title> <description> <state>");
			Console.WriteLine("Commands: create, delete, edit, print, setstate");
			Console.WriteLine("States: Proposed, Active, Resolved, Closed");
		}
	}
}
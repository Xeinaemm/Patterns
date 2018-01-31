using System;
using Patterns.State.Implementation;

namespace Patterns.State.States
{
	public class BaseState
	{
		public void Print(WorkItem wi)
		{
			Console.WriteLine($"   Id:	{wi.Id}");
			Console.WriteLine($"State:	{wi.State}");
			Console.WriteLine($"Title:	{wi.Title}");
			Console.WriteLine($" Desc:	{wi.Description}");
		}
	}
}
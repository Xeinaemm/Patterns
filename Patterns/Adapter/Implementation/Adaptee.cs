using System.Collections.Generic;

namespace Patterns.Adapter.Implementation
{
	public static class Adaptee
	{
		public static IList<string> GetList() => new List<string> {"Adapter", "pattern", "is", "usefull", "!"};
	}
}
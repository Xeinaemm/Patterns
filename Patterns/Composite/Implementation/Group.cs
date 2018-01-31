using System.Collections.Generic;
using System.Linq;
using Patterns.Composite.Contracts;

namespace Patterns.Composite.Implementation
{
	public class Group : IParty
	{
		public Group() => Members = new List<IParty>();

		public IList<IParty> Members { get; }
		public string Name { get; set; }

		public int Gold
		{
			get => Members.Sum(member => member.Gold);
			set
			{
				if (Members.Count == 0) return;
				var eachSplit = value / Members.Count;
				foreach (var member in Members)
					member.Gold += eachSplit;
			}
		}
	}
}
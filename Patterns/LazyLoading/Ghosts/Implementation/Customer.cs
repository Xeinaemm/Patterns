using System.Collections;

namespace Patterns.LazyLoading.Ghosts.Implementation
{
	public class Customer : DomainObject
	{
		public Customer(int id) : base(id)
		{
		}

		protected override void DoLoadLine(ArrayList dataRow)
		{
		}

		protected override ArrayList GetDataRow() => new ArrayList();
	}
}
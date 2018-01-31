// ReSharper disable NonReadonlyMemberInGetHashCode

namespace Patterns.LazyLoading.VirtualProxy
{
	public class Order
	{
		public int Id { get; set; }
		protected virtual Customer Customer { get; set; }

		public string Print() => $"{Customer.CompanyName} {Customer.Address}";

		public override int GetHashCode() => Id.GetHashCode();
	}
}
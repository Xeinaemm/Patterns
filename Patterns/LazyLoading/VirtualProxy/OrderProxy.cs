namespace Patterns.LazyLoading.VirtualProxy
{
	public class OrderProxy : Order
	{
		protected override Customer Customer
		{
			get => base.Customer ?? (base.Customer = new Customer());
			set => base.Customer = value;
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Order order)) return false;
			return order.Id == Id;
		}

		public override int GetHashCode() => base.GetHashCode();
	}
}
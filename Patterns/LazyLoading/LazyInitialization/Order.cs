namespace Patterns.LazyLoading.LazyInitialization
{
	public class Order
	{
		private Customer _customer;

		//No thread-safe
		public Customer Customer => _customer ?? (_customer = new Customer());

		public string Print() => $"{Customer.CompanyName} {Customer.Address}";
	}
}
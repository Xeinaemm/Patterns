using System;

namespace Patterns.LazyLoading.LazyInitialization
{
	public class OrderLazy
	{
		private readonly Lazy<Customer> _customerLazy;

		public OrderLazy()
		{
			_customerLazy = new Lazy<Customer>(() => new Customer());
		}

		private Customer Customer => _customerLazy.Value;

		public string Print() => $"{Customer.CompanyName} {_customerLazy.Value.Address}";
	}
}
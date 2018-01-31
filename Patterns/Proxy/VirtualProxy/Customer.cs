namespace Patterns.Proxy.VirtualProxy
{
	public class Customer
	{
		public Customer()
		{
			CompanyName = "Company Name";
			Address = "Address";
		}

		public string CompanyName { get; }
		public string Address { get; }
	}
}
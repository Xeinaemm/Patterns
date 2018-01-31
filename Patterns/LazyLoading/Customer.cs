namespace Patterns.LazyLoading
{
	public class Customer
	{
		public Customer()
		{
			CompanyName = "Company Name";
			Address = "Address";
		}

		public string CompanyName { get; set; }
		public string Address { get; set; }
	}
}
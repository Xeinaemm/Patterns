using System;

namespace Patterns.Repository.CachedRepository.Entities
{
	[Serializable]
	public class OrderEntity
	{
		public int CustomerId;
		public int Id;
		public DateTime OrderDate;
		public int[] OrderDetails;
	}
}
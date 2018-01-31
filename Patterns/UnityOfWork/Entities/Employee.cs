using System;
using System.Collections.Generic;
using Patterns.UnityOfWork.Contracts;

namespace Patterns.UnityOfWork.Entities
{
	public class Employee : IEntity
	{
		public virtual string Name { get; set; }
		public virtual DateTime HireDate { get; set; }
		public virtual ICollection<TimeCard> TimeCards { get; set; }
		public virtual int Id { get; set; }
	}
}
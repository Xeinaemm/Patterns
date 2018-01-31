using System;
using Patterns.UnityOfWork.Contracts;

namespace Patterns.UnityOfWork.Entities
{
	public class TimeCard : IEntity
	{
		public virtual int Hours { get; set; }
		public DateTime EffectiveDate { get; set; }
		public virtual int Id { get; set; }
	}
}
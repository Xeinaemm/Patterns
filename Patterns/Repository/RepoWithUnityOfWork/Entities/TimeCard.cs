using System;
using Patterns.Repository.RepoWithUnityOfWork.Contracts;

namespace Patterns.Repository.RepoWithUnityOfWork.Entities
{
	public class TimeCard : IEntity
	{
		public virtual int Hours { get; set; }
		public DateTime EffectiveDate { get; set; }
		public virtual int Id { get; set; }
	}
}